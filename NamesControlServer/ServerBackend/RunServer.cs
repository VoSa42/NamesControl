using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using NamesControlLib;

namespace NamesControlServer.ServerBackend
{
    internal static class RunServer
    {
        public static void Run()
        {
            Console.WriteLine("run server");

            ConnectDatabase();

            // Set up and activate listener to wait and recieve message from client
            IPEndPoint ipep = new IPEndPoint(ServerMetadata.ServerIPAddress, ServerMetadata.Port);
            TcpListener listener = new TcpListener(ipep);
            listener.Start();

            // Set buffer of static defined size to storing recieved message
            byte[] buffer = new byte[ServerMetadata.MaxPacketSize];

            while (true)
            {
                // Connection to client, who send server a request (message)
                var sender = listener.AcceptTcpClient();

                // Reads the byte stream from sender and store them into buffer
                _ = sender.GetStream().Read(buffer);

                Command command = SocketManager.MessageToCommand(buffer);
                Console.WriteLine(command);
                string answer = CommandHandler.CommandExecutor(command);
                Console.WriteLine($"Answer: {answer}");
            }
        }

        public static void ConnectDatabase()
        {
            Console.WriteLine("connecting to database");

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=C:\\Users\\Admin\\Documents\\prace\\eprin\\pripadovka\\NamesControl\\NamesControlServer\\Database\\NamesDat.mdf;" +
                "Integrated Security=True;" +
                "Connect Timeout=30";

            Console.WriteLine("connection string");

            /*string query = "CREATE TABLE [dbo].[Names] (" +
                "    [Id]         INT           IDENTITY (1, 1) NOT NULL," +
                "    [FirstName]  NVARCHAR (50) NOT NULL," +
                "    [SecondName] NVARCHAR (50) NOT NULL," +
                "    PRIMARY KEY CLUSTERED ([Id] ASC)" +
                ");";*/

            string query = "INSERT INTO Names (FirstName, SecondName) VALUES ('John', 'Doe');";

            Console.WriteLine("query");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("before openning");

                connection.Open();

                Console.WriteLine("connection opened");

                /*using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Column"].ToString());
                        }
                    }
                }*/
            }
        }
    }
}
