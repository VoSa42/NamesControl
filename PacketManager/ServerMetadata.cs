using System.Configuration;
using System.Net;

namespace NamesControlLib
{
    public static class ServerMetadata
    {
        public static IPAddress ServerIPAddress { get { return IPAddress.Loopback; } }
        public static int Port { get { return 1234; } }
        public static int MaxSocketSize { get { return 1024 * 64; } }
    }
}
