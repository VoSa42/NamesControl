using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlServer.ServerBackend
{
    internal static class RunServer
    {
        public static void Run()
        {
            while (true)
            {
                string command = "Dummy";
                string answer = CommandHandler.CommandExecutor(command);
                Console.WriteLine(answer);
                break;
            }
        }
    }
}
