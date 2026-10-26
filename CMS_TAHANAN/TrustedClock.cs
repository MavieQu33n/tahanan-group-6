using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

public static class TrustedClock
{
    private static DateTime _baseUtc;
    private static readonly Stopwatch _sw = new Stopwatch();
    private static readonly TimeSpan PhOffset = TimeSpan.FromHours(8);

    public static bool IsSynced { get; private set; }
    public static DateTime UtcNow => _baseUtc + _sw.Elapsed;

    public static DateTime DavaoNow => UtcNow + PhOffset;

    public static async Task<bool> SyncAsync()
    {
        DateTime? time = await Task.Run(() =>
            GetNtpTime("time.windows.com") ?? GetNtpTime("pool.ntp.org"));

        if (time == null)
            time = await GetHttpTime();

        if (time == null) return false;

        _baseUtc = time.Value;
        _sw.Restart();
        IsSynced = true;
        return true;
    }

    private static DateTime? GetNtpTime(string server)
    {
        try
        {
            var data = new byte[48];
            data[0] = 0x1B;

            using (var udp = new UdpClient())
            {
                udp.Client.ReceiveTimeout = 3000;
                udp.Client.SendTimeout = 3000;
                udp.Connect(server, 123);
                udp.Send(data, data.Length);

                var ep = new IPEndPoint(IPAddress.Any, 0);
                data = udp.Receive(ref ep);
            }

            ulong seconds = ((ulong)data[40] << 24) | ((ulong)data[41] << 16)
                          | ((ulong)data[42] << 8) | data[43];
            ulong fraction = ((ulong)data[44] << 24) | ((ulong)data[45] << 16)
                           | ((ulong)data[46] << 8) | data[47];

            double ms = seconds * 1000.0 + fraction * 1000.0 / 4294967296.0;
            return new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(ms);
        }
        catch { return null; }
    }

    private static async Task<DateTime?> GetHttpTime()
    {
        try
        {
            using (var client = new HttpClient { Timeout = TimeSpan.FromSeconds(5) })
            using (var req = new HttpRequestMessage(HttpMethod.Head, "https://www.microsoft.com"))
            using (var res = await client.SendAsync(req))
            {
                return res.Headers.Date?.UtcDateTime;
            }
        }
        catch { return null; }
    }
}