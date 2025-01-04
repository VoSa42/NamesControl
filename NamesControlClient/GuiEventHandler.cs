using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlClient
{
    internal static class GuiEventHandler
    {
        public static void TestClickHandler()
        {
            TcpClient client = new TcpClient(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
            NetworkStream stream = client.GetStream();

            byte[] message = PacketManager.StringToJson("command");
            stream.Write(message);

            stream.Dispose();
            client.Close();
        }
    }
}
