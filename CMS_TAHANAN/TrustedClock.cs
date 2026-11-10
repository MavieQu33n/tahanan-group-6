using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace CMS_TAHANAN
{
    internal sealed class TrustedClock : IDisposable
    {
        private static readonly string[] HttpServers =
        {
            "https://www.google.com/",
            "https://www.cloudflare.com/",
            "https://www.microsoft.com/"
        };

        private static readonly string[] NtpServers =
        {
            "time.cloudflare.com",
            "time.google.com",
            "pool.ntp.org"
        };

        private static readonly HttpClient HttpClient = CreateHttpClient();
        private readonly object syncRoot = new object();
        private readonly Stopwatch stopwatch = new Stopwatch();
        private DateTime utcAtSynchronization;
        private bool isSynchronized;

        public bool IsSynchronized
        {
            get
            {
                lock (syncRoot)
                {
                    return isSynchronized;
                }
            }
        }

        public DateTime Now
        {
            get
            {
                lock (syncRoot)
                {
                    if (!isSynchronized)
                    {
                        throw new InvalidOperationException("The clock has not been synchronized.");
                    }

                    return utcAtSynchronization.AddMilliseconds(stopwatch.Elapsed.TotalMilliseconds);
                }
            }
        }

        public async Task<bool> SynchronizeAsync(CancellationToken cancellationToken)
        {
            foreach (string server in HttpServers)
            {
                try
                {
                    DateTime utc = await QueryHttpServerAsync(server, cancellationToken);
                    SetSynchronizedTime(utc);
                    return true;
                }
                catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException || ex is InvalidOperationException)
                {
                }
            }

            foreach (string server in NtpServers)
            {
                try
                {
                    DateTime utc = await QueryNtpServerAsync(server, cancellationToken);
                    SetSynchronizedTime(utc);
                    return true;
                }
                catch (Exception ex) when (ex is SocketException || ex is TimeoutException || ex is InvalidOperationException)
                {
                }
            }

            return false;
        }

        private void SetSynchronizedTime(DateTime utc)
        {
            lock (syncRoot)
            {
                utcAtSynchronization = DateTime.SpecifyKind(utc, DateTimeKind.Utc);
                stopwatch.Restart();
                isSynchronized = true;
            }
        }

        private static async Task<DateTime> QueryHttpServerAsync(string server, CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Head, server))
            using (HttpResponseMessage response = await HttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                response.EnsureSuccessStatusCode();
                if (!response.Headers.Date.HasValue)
                {
                    throw new InvalidOperationException("The server did not return an authoritative date.");
                }

                return response.Headers.Date.Value.UtcDateTime;
            }
        }

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.UserAgent.ParseAdd("TAHANAN-Cemetery-Management-System");
            return client;
        }

        private static async Task<DateTime> QueryNtpServerAsync(string server, CancellationToken cancellationToken)
        {
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.ReceiveTimeout = 3000;
                udpClient.Client.SendTimeout = 3000;
                await udpClient.SendAsync(CreateRequest(), 48, server, 123);

                UdpReceiveResult response = await ReceiveAsync(udpClient, cancellationToken);
                if (response.Buffer.Length < 48)
                {
                    throw new InvalidOperationException("The NTP response was incomplete.");
                }

                byte[] buffer = response.Buffer;
                ulong seconds = ReadUInt32(buffer, 40);
                ulong fraction = ReadUInt32(buffer, 44);
                double milliseconds = (seconds * 1000.0) + ((fraction * 1000.0) / 4294967296.0);

                return DateTime.SpecifyKind(new DateTime(1900, 1, 1).AddMilliseconds(milliseconds), DateTimeKind.Utc);
            }
        }

        private static async Task<UdpReceiveResult> ReceiveAsync(UdpClient udpClient, CancellationToken cancellationToken)
        {
            Task<UdpReceiveResult> receiveTask = udpClient.ReceiveAsync();
            Task completedTask = await Task.WhenAny(receiveTask, Task.Delay(3000, cancellationToken));
            if (completedTask != receiveTask)
            {
                cancellationToken.ThrowIfCancellationRequested();
                throw new TimeoutException("The NTP server did not respond.");
            }

            return await receiveTask;
        }

        private static byte[] CreateRequest()
        {
            var request = new byte[48];
            request[0] = 0x1B;
            return request;
        }

        private static ulong ReadUInt32(byte[] buffer, int offset)
        {
            return ((ulong)buffer[offset] << 24)
                | ((ulong)buffer[offset + 1] << 16)
                | ((ulong)buffer[offset + 2] << 8)
                | buffer[offset + 3];
        }

        public void Dispose()
        {
            lock (syncRoot)
            {
                stopwatch.Stop();
            }
        }
    }
}
