using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlServer.ServerBackend
{
    internal static class RunServer
    {
        public static void Run()
        {
            IPEndPoint ipep = new IPEndPoint(ProgramServer.ServerIPAddress, ProgramServer.port);
            TcpListener listener = new TcpListener(ipep);
            listener.Start();

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
