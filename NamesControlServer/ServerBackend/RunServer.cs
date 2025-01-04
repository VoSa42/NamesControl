using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlServer.ServerBackend
{
    internal static class RunServer
    {
        public static void Run()
        {
            // Set up and activate listener to wait and recieve message from client
            IPEndPoint ipep = new IPEndPoint(ProgramServer.ServerIPAddress, ProgramServer.port);
            TcpListener listener = new TcpListener(ipep);
            listener.Start();

            // Set buffer of static defined size to storing recieved message
            byte[] buffer = new byte[0];

            // Connection to client, who send server a request (message)
            var sender = listener.AcceptTcpClient();

            while (true)
            {
                // Reads the byte stream from sender and store them into buffer
                sender.GetStream().ReadExactly(buffer);

                string command = PacketManager.UnwrapCommand(buffer);
                string answer = CommandHandler.CommandExecutor(command);
                Console.WriteLine(answer);
            }
        }
    }
}
