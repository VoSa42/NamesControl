using NamesControlLib;
using NamesControlLib.Errors;
using NamesControlLib.Messages;
using NamesControlServer.Database;

namespace NamesControlServer.ServerBackend
{
    /// <summary>
    /// Represents reference to adequate command handler menthod which will be calld
    /// </summary>
    internal delegate ServerResponse CommandHandlerFunc(Command com);

    /// <summary>
    /// Represents server application layer.
    /// </summary>
    internal class CommandHandler
    {
        /// <summary>
        /// Executes adequate command.
        /// </summary>
        /// <param name="buffer"> Socket recieved from network. </param>
        /// <returns> Full answer including the error message. </returns>
        public static ServerResponse ExecuteCommand(byte[] buffer)
        {
            Command com = SocketManager.SocketToMessage<Command>(buffer);

            CommandHandlerFunc comHandler = com.CommandName switch
            {
                CommandType.Add => new(AddHandler),
                CommandType.Remove => new(RemoveHandler),
                CommandType.Edit => new(EditHandler),
                CommandType.Refresh => new(RefreshHandler),
                _ => new(IncorrectInputHandler),
            };

            return comHandler(com);
        }

        /// <summary>
        /// Command handlers below.
        /// </summary>
        private static ServerResponse AddHandler(Command com)
        {
            ServerResponse answer = new(DatabaseManager.AddRecord(com.FirstName, com.SecondName),
                DatabaseManager.GetTable());
            return answer;
        }

        private static ServerResponse RemoveHandler(Command com)
        {
            ServerResponse answer = new(DatabaseManager.RemoveRecord(com.Id),
                DatabaseManager.GetTable());
            return answer;
        }

        private static ServerResponse EditHandler(Command com)
        {
            ServerResponse answer = new(DatabaseManager.EditRecord(com.Id, com.FirstName, com.SecondName),
                DatabaseManager.GetTable());
            return answer;
        }

        private static ServerResponse RefreshHandler(Command com)
        {
            ServerResponse answer = new(ErrorType.None, DatabaseManager.GetTable());
            return answer;
        }

        private static ServerResponse IncorrectInputHandler(Command com)
        {
            ServerResponse answer = new(ErrorType.InvalidQuery, DatabaseManager.GetTable());
            return answer;
        }
    }
}
