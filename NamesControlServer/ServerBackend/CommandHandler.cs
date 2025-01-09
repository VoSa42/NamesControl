using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlServer.ServerBackend
{
    internal delegate string CommandHandlerFunc(Command com);

    internal class CommandHandler
    {
        public static string CommandExecutor(Command com)
        {
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

        private static string NullHandler(Command com)
        {
            return "Null";
        }

        private static string AddHandler(Command com)
        {
            return "Add";
        }

        private static string RemoveHandler(Command com)
        {
            return "Remove";
        }

        private static string EditHandler(Command com)
        {
            return "Edit";
        }

        private static string RefreshHandler(Command com)
        {
            return "Refresh";
        }

        private static string IncorrectInputHandler(Command com)
        {
            return "Unknown input";
        }
    }
}
