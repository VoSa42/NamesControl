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
            Console.WriteLine(com);

            CommandHandlerFunc comHandler = new(NullHandler);

            switch (com.command)
            {
                case CommandType.None:
                    comHandler = new(NullHandler);
                    break;
                case CommandType.Add:
                    comHandler = new(AddHandler);
                    break;
                case CommandType.Remove:
                    comHandler = new(RemoveHandler);
                    break;
                case CommandType.Edit:
                    comHandler = new(EditHandler);
                    break;
                case CommandType.Refresh:
                    comHandler = new(RefreshHandler);
                    break;
                default:
                    comHandler = new(IncorrectInputHandler);
                    break;
            }

            return comHandler(com);
        }

        private static ServerAnswer NullHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.GetGrid(), "No reqest");     // This should throw an exception instead of error message (because this should not happen)
            return answer;
        }

        private static ServerAnswer AddHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.GetGrid(), DatabaseManager.AddRecord());
            return answer;
        }

        private static ServerAnswer RemoveHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.GetGrid(), DatabaseManager.RemoveRecord());
            return answer;
        }

        private static ServerAnswer EditHandler(Command com)
        {
            ServerAnswer answer =
                new(DatabaseManager.GetGrid(), DatabaseManager.EditRecord());
            return answer;
        }

        private static ServerAnswer RefreshHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.GetGrid());
            return answer;
        }

        private static ServerAnswer IncorrectInputHandler(Command com)
        {
            ServerAnswer answer = new(DatabaseManager.GetGrid(), "Incorrect request");     // This should throw an exception instead of error message (because this should not happen)
            return answer;
        }
    }
}
