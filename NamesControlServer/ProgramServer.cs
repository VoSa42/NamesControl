﻿using System;
using System.Net;

namespace NamesControlServer
{
    public class ProgramServer
    {
        // Configurable IP address and port
        public static int port = 1234;
        public static IPAddress ServerIPAddress = IPAddress.Loopback;

        // Defines the size of one packet
        public static int packetSize = 64 * 1024;

        static void Main(string[] args)
        {
            ServerBackend.RunServer.Run();
        }
    }
}