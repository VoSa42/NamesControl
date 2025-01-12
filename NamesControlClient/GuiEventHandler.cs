using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;
using NamesControlLib.Messages;

namespace NamesControlClient
{
    internal static class GuiEventHandler
    {
        private static ServerAnswer ProcessCommand(Command command)
        {
            TcpClient client = new(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
            NetworkStream stream = client.GetStream();

            byte[] messageToSend = SocketManager.MessageToSocket(command);
            stream.Write(messageToSend);

            byte[] recievedMessage = new byte[ServerMetadata.MaxSocketSize]; 

            _ = stream.Read(recievedMessage);

            ServerAnswer answer = SocketManager.SocketToMessage<ServerAnswer>(recievedMessage);

            stream.Dispose();
            client.Close();

            return answer;
        }

        public static ServerAnswer AddNewNameHandler(string fstName, string sndName)
        {
            Command com = new(CommandType.Add, fstName, sndName);
            return ProcessCommand(com);
        }

        public static ServerAnswer EditNameHandler(int id, string fstName, string sndName)
        {
            Command com = new(CommandType.Edit, fstName, sndName, id);
            return ProcessCommand(com);
        }

        public static ServerAnswer RemoveNameHandler(int id)
        {
            Command com = new(CommandType.Remove, id: id);
            return ProcessCommand(com);
        }

        public static ServerAnswer RefreshHandler()
        {
            Command com = new(CommandType.Refresh);
            return ProcessCommand(com);
        }
    }
}
