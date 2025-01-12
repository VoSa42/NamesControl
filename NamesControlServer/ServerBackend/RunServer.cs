using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using NamesControlLib;
using NamesControlLib.Messages;

namespace NamesControlServer.ServerBackend
{
    internal static class RunServer
    {
        public static void Run()
        {
            Console.WriteLine("run server");        // log

            // Set up and activate listener to wait and recieving message from client
            IPEndPoint ipep = new(ServerMetadata.ServerIPAddress, ServerMetadata.Port);
            TcpListener listener = new(ipep);
            listener.Start();

            while (true)
            {
                // Set buffer of static defined size to storing recieved message
                byte[] buffer = new byte[ServerMetadata.MaxSocketSize];

                // Saves connection to client, who sent a request (message) to server
                TcpClient sender = listener.AcceptTcpClient();

                // Reads the byte stream from sender and store them into buffer
                _ = sender.GetStream().Read(buffer);

                ServerAnswer answer = CommandHandler.CommandExecutor(buffer);
                //Console.WriteLine($"Answer:\n{answer}");

                byte[] answerSocket = SocketManager.MessageToSocket(answer);
                sender.GetStream().Write(answerSocket);
            }
        }
    }
}
