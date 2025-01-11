using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlLib
{
    public static class ServerMetadata
    {
        public static IPAddress ServerIPAddress = IPAddress.Loopback;
        public const int Port = 1234;

        public const int MaxSocketSize = 64 * 1024;
    }
}
