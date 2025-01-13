using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using NamesControlClient.Errors;
using NamesControlLib;
using NamesControlLib.Messages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NamesControlClient
{
    internal static class GuiEventHandler
    {
        private static ServerAnswer ProcessCommand(Command command)
        {
            ServerAnswer answer = new(ErrorType.None, null);

            try
            {
                TcpClient client = new(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
                NetworkStream stream = client.GetStream();

                byte[] messageToSend = SocketManager.MessageToSocket(command);
                stream.Write(messageToSend);

                byte[] recievedMessage = new byte[ServerMetadata.MaxSocketSize];

                _ = stream.Read(recievedMessage);

                answer = SocketManager.SocketToMessage<ServerAnswer>(recievedMessage);

                stream.Dispose();
                client.Close();
            }
            catch (Exception)
            {
                answer = new(ErrorType.ServerNotResponse, null);
                MessageBox.Show(ErrorMessages.GetErrorMessage(ErrorType.ServerNotResponse), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
