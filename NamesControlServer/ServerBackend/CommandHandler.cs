using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;
using NamesControlLib.Messages;
using NamesControlServer.Database;

namespace NamesControlServer.ServerBackend
{
    internal delegate ServerAnswer CommandHandlerFunc(Command com);

    internal class CommandHandler
    {
        public static ServerAnswer CommandExecutor(byte[] buffer)
        {
            Command com = SocketManager.SocketToMessage<Command>(buffer);

            Console.WriteLine(com);     // log

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
            ServerAnswer answer = new("No reqest",
                DatabaseManager.GetGrid());     // This should throw an exception instead of error message (because this should not happen)
            return answer;
        }

        private static ServerAnswer AddHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.AddRecord(com.FirstName,
                com.SecondName), DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer RemoveHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.RemoveRecord(com.Id),
                DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer EditHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.EditRecord(com.Id, com.FirstName, com.SecondName),
                DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer RefreshHandler(Command com)
        {
            ServerAnswer answer =
                new(null, DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer IncorrectInputHandler(Command com)
        {
            ServerAnswer answer = new("Incorrect request",
                DatabaseManager.GetGrid());     // This should throw an exception instead of error message (because this should not happen)
            return answer;
        }
    }
}
