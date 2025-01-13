using NamesControlLib;
using NamesControlLib.Errors;
using NamesControlLib.Messages;
using NamesControlServer.Database;

namespace NamesControlServer.ServerBackend
{
    internal delegate ServerAnswer CommandHandlerFunc(Command com);

    internal class CommandHandler
    {
        public static ServerAnswer ExecuteCommand(byte[] buffer)
        {
            Command com = SocketManager.SocketToMessage<Command>(buffer);

            CommandHandlerFunc comHandler = com.CommandName switch
            {
                CommandType.None => new(NullHandler),
                CommandType.Add => new(AddHandler),
                CommandType.Remove => new(RemoveHandler),
                CommandType.Edit => new(EditHandler),
                CommandType.Refresh => new(RefreshHandler),
                _ => new(IncorrectInputHandler),
            };

            return comHandler(com);
        }

        private static ServerAnswer NullHandler(Command com)
        {
            ServerAnswer answer = new(ErrorType.InvalidQuery, DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer AddHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.AddRecord(com.FirstName, com.SecondName),
                DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer RemoveHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.RemoveRecord(com.Id),
                DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer EditHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.EditRecord(com.Id, com.FirstName, com.SecondName),
                DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer RefreshHandler(Command com)
        {
            ServerAnswer answer = new(ErrorType.None, DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer IncorrectInputHandler(Command com)
        {
            ServerAnswer answer = new(ErrorType.InvalidQuery, DatabaseManager.GetGrid());
            return answer;
        }
    }
}
