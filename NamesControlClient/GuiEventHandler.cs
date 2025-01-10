﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;
using NamesControlLib.Messages;

namespace NamesControlClient
{
    internal static class GuiEventHandler
    {
        public static void EncodeAndSendMessage(Command command)
        {
            TcpClient client = new TcpClient(ServerMetadata.ServerIPAddress.ToString(), ServerMetadata.Port);
            NetworkStream stream = client.GetStream();

            byte[] message = SocketManager.MessageToSocket(command);
            stream.Write(message);

            //stream.Dispose();
            //client.Close();
        }

        public static void AddNewNameHandler(string fstName, string sndName)
        {
            Command com = new Command(CommandType.Add, fstName, sndName);
            EncodeAndSendMessage(com);
        }

        public static void EditNameHandler(int id, string fstName, string sndName)
        {
            Command com = new Command(CommandType.Edit, fstName, sndName, id);
            EncodeAndSendMessage(com);
        }

        public static void RemoveNameHandler(int id)
        {
            Command com = new Command(CommandType.Remove, _id: id);
            EncodeAndSendMessage(com);
        }

        public static void RefreshHandler()
        {
            Command com = new Command(CommandType.Refresh);
            EncodeAndSendMessage(com);
        }
    }
}
