using Newtonsoft.Json;
using System.Text;

namespace NamesControlLib
{
    public static class SocketManager
    {
        public static byte[] MessageToSocket<messageType>(messageType mess)
        {
            string jsonCommand = JsonConvert.SerializeObject(mess);
            byte[] socket = Encoding.Unicode.GetBytes(jsonCommand);

            return socket;
        }

        public static messageType SocketToMessage<messageType>(byte[] bytesBuffer)
        {
            string jsonMessage = Encoding.Unicode.GetString(bytesBuffer);

            messageType message = JsonConvert.DeserializeObject<messageType>(jsonMessage);

            return message;
        }
    }
}
