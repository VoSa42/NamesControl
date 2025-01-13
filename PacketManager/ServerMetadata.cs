using System.Net;

namespace NamesControlLib
{
    public static class ServerMetadata
    {
        public static IPAddress ServerIPAddress
        {
            get
            {
                /*var ipAddress = IPAddress.Parse(ConfigurationManager.AppSettings["ServerIpAddress"]);
                Console.WriteLine(ipAddress);
                if (ipAddress == null) { throw new NullReferenceException("Bad configuration"); }
                return ipAddress;*/
                return IPAddress.Loopback;
            }
        }
        public static int Port// { get { return int.Parse(ConfigurationManager.AppSettings["Port"]); } }
        {
            get
            {
                /*_ = int.TryParse(ConfigurationManager.AppSettings["port"], out int port);
                Console.WriteLine(port);
                return port;*/
                return 1234;
            }
        }

        public static int MaxSocketSize// { get { return int.Parse(ConfigurationManager.AppSettings["MaxSocketSize"]); } }
        {
            get
            {
                /*_ = int.TryParse(ConfigurationManager.AppSettings["MaxSocketSize"], out int maxSocketSize);
                return maxSocketSize;*/
                return 1024 * 64;
            }
        }
    }
}
