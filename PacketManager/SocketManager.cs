using Newtonsoft.Json;
using System.Text;

using NamesControlLib.Messages;

namespace NamesControlLib
{
    public static class SocketManager
    {
        public static byte[] MessageToSocket(Message mess)
        {
            string jsonCommand = mess.GetJson();
            byte[] socket = Encoding.Unicode.GetBytes(jsonCommand);

            return socket;
        }

        public static messageType SocketToMessage<messageType>(byte[] bytesBuffer)
        {
            string jsonMessage = Encoding.Unicode.GetString(bytesBuffer);

            Console.WriteLine(jsonMessage);

            messageType message = JsonConvert.DeserializeObject<messageType>(jsonMessage);

            return message;
        }
    }
}
