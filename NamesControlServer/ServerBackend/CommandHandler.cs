using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlServer.ServerBackend
{
    internal delegate string CommandHandlerFunc();

    internal class CommandHandler
    {
        public static string CommandExecutor(string command)
        {
            CommandHandlerFunc comHandler = new(NullHandler);

            switch (command)
            {
                case null:
                    comHandler = new(NullHandler);
                    break;
                case "":
                    comHandler = new(NullHandler);
                    break;
                case "exit":
                    comHandler = new(ExitHandler);
                    break;
                default:
                    comHandler = new(IncorrectInputHandler);
                    break;
            }

            return comHandler();
        }

        private static string NullHandler()
        {
            return "Null";
        }

        private static string ExitHandler()
        {
            return "Exit";
        }

        private static string IncorrectInputHandler()
        {
            return "Unknown input";
        }
    }
}
