using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlServer.ServerBackend
{
    internal delegate string CommandHandlerFunc(Command com);

    internal class CommandHandler
    {
        public static string CommandExecutor(string command)
        {
            Command parsedCom = new(command);

            CommandHandlerFunc comHandler = new(NullHandler);

            switch (parsedCom.command)
            {
                case "":
                    comHandler = new(NullHandler);
                    break;
                case "add":
                    comHandler = new(AddHandler);
                    break;
                case "remove":
                    comHandler = new(RemoveHandler);
                    break;
                case "edit":
                    comHandler = new(EditHandler);
                    break;
                default:
                    comHandler = new(IncorrectInputHandler);
                    break;
            }

            return comHandler(parsedCom);
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

        private static string IncorrectInputHandler(Command com)
        {
            return "Unknown input";
        }
    }
}
