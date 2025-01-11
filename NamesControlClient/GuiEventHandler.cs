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
        public static ServerAnswer CommandExecutor(Command command)
        {
            TcpClient client = new TcpClient(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
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
            Command com = new Command(CommandType.Add, fstName, sndName);
            return CommandExecutor(com);
        }

        public static ServerAnswer EditNameHandler(int id, string fstName, string sndName)
        {
            Command com = new Command(CommandType.Edit, fstName, sndName, id);
            return CommandExecutor(com);
        }

        public static ServerAnswer RemoveNameHandler(int id)
        {
            Command com = new Command(CommandType.Remove, _id: id);
            return CommandExecutor(com);
        }

        public static ServerAnswer RefreshHandler()
        {
            Command com = new Command(CommandType.Refresh);
            return CommandExecutor(com);
        }
    }
}
