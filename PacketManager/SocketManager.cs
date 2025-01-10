using Newtonsoft.Json;
using System.Text;

using NamesControlLib.Messages;

namespace NamesControlLib
{
    public static class SocketManager
    {
        // Misto 'Command' bude genericky typ nebo abstraktni trida 'Socket'.
        // Taky to chce adekvatne prejmenovat metody

        public static byte[] MessageToSocket(Message command)
        {
            string jsonCommand = command.GetJson();
            byte[] socket = Encoding.Unicode.GetBytes(jsonCommand);

            return socket;
        }

        public static Message SocketToMessage(byte[] bytesBuffer)
        {
            string jsonMessage = Encoding.Unicode.GetString(bytesBuffer);

            Message message = JsonConvert.DeserializeObject<Message>(jsonMessage);

            return message;
        }
    }
}
