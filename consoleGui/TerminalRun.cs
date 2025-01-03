using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControl.consoleGui
{
    internal delegate int CommandHandler();

    public static class TerminalRun
    {
        public static void Run()
        {
            string? command = "";
            CommandHandler comHandler = new(NullHandler);

            while (true)
            {
                Console.Write("~NamesControl-command: ");
                command = Console.ReadLine();

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
                
                if (comHandler() > 0)
                {
                    Console.WriteLine("Closing NamesControl application");
                    break;
                }
            }
        }

        private static int NullHandler()
        {
            return 0;
        }

        private static int ExitHandler()
        {
            return 1;
        }
        private static int IncorrectInputHandler()
        {
            Console.WriteLine("Unknown input");
            return 0;
        }
    }
}
