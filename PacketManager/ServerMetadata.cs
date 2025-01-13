using System.Configuration;
using System.Net;

namespace NamesControlLib
{
    public static class ServerMetadata
    {
        public static IPAddress ServerIPAddress { get { return IPAddress.Loopback; } }
        public static int Port { get { return 1234; } }
        public static int MaxSocketSize { get { return 1024 * 64; } }

        /*public static IPAddress ServerIPAddress
        {
            get
            {
                var ipAddress = IPAddress.Parse(ConfigurationManager.AppSettings["ServerIpAddress"]);
                Console.WriteLine(ipAddress);
                if (ipAddress == null) { throw new NullReferenceException("Bad configuration"); }
                return ipAddress;
            }
        }
        public static int Port
        {
            get
            {
                _ = int.TryParse(ConfigurationManager.AppSettings["port"], out int port);
                Console.WriteLine(port);
                return port;
            }
        }

        public static int MaxSocketSize
        {
            get
            {
                _ = int.TryParse(ConfigurationManager.AppSettings["MaxSocketSize"], out int maxSocketSize);
                return maxSocketSize;
            }
        }*/
    }
}
