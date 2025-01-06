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
        public static void EncodeAndSendMessage(string command)
        {
            TcpClient client = new TcpClient(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
            NetworkStream stream = client.GetStream();

            byte[] message = PacketManager.StringToJson(command);
            stream.Write(message);

            stream.Dispose();
            client.Close();
        }

        public static void AddNewNameHandler(string fstName, string sndName)
        {
            string fullCommand = "add-" + fstName + "-" + sndName;
            EncodeAndSendMessage(fullCommand);
        }

        public static void EditNameHandler(int id, string fstName, string sndName)
        {
            string fullCommand = "edit-" + id + "-" + fstName + "-" + sndName;
            EncodeAndSendMessage(fullCommand);
        }
    }
}
