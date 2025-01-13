using System.Net.Sockets;
using NamesControlLib;
using NamesControlLib.Errors;
using NamesControlLib.Messages;

namespace NamesControlClient
{
    /// <summary>
    /// Handle events from GUI (WinForms) and realize network communication with server.
    /// </summary>
    internal static class GuiEventHandler
    {
        /// <summary>
        /// Gets command from event handlers below, process them into queries for database,
        /// encode them and send to the server.
        /// After server process the query, this method recieve servers answer.
        /// </summary>
        /// <param name="command"> Request to a database </param>
        /// <returns> Server answer </returns>
        private static ServerResponse ProcessCommand(Command command)
        {
            ServerResponse answer = new(ErrorType.None, null);

            try
            {
                TcpClient client = new(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
                NetworkStream stream = client.GetStream();

                byte[] messageToSend = SocketManager.MessageToSocket(command);
                stream.Write(messageToSend);

                byte[] recievedMessage = new byte[ServerMetadata.MaxSocketSize];

                _ = stream.Read(recievedMessage);

                answer = SocketManager.SocketToMessage<ServerResponse>(recievedMessage);

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

        /// <summary>
        /// GUI event hendler below
        /// </summary>
        public static ServerResponse AddNewNameHandler(string fstName, string sndName)
        {
            Command com = new(CommandType.Add, fstName, sndName);
            return ProcessCommand(com);
        }

        public static ServerResponse EditNameHandler(int id, string fstName, string sndName)
        {
            Command com = new(CommandType.Edit, fstName, sndName, id);
            return ProcessCommand(com);
        }

        public static ServerResponse RemoveNameHandler(int id)
        {
            Command com = new(CommandType.Remove, id: id);
            return ProcessCommand(com);
        }

        public static ServerResponse RefreshHandler()
        {
            Command com = new(CommandType.Refresh);
            return ProcessCommand(com);
        }
    }
}
