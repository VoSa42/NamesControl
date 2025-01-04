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
            TcpClient client = new TcpClient("127.0.0.1", 1234);
            NetworkStream stream = client.GetStream();

            byte[] message = PacketManager.WrapCommand("command");
            stream.Write(message);

            stream.Dispose();
            client.Close();
        }
    }
}
