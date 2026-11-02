using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace CMS_TAHANAN
{
    internal sealed class TrustedClock : IDisposable
    {
        private static readonly string[] Servers =
        {
            "time.cloudflare.com",
            "time.google.com",
            "pool.ntp.org"
        };

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
            foreach (string server in Servers)
            {
                try
                {
                    DateTime utc = await QueryServerAsync(server, cancellationToken);
                    lock (syncRoot)
                    {
                        utcAtSynchronization = utc;
                        stopwatch.Restart();
                        isSynchronized = true;
                    }
                    return true;
                }
                catch (Exception ex) when (ex is SocketException || ex is TimeoutException || ex is InvalidOperationException)
                {
                    // Try the next time server when a server is unavailable.
                }
            }

            return false;
        }

        private static async Task<DateTime> QueryServerAsync(string server, CancellationToken cancellationToken)
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

                return DateTime.SpecifyKind(
                    new DateTime(1900, 1, 1).AddMilliseconds(milliseconds),
                    DateTimeKind.Utc);
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
