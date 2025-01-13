using Newtonsoft.Json;
using System.Text;

namespace NamesControlLib
{
    /// <summary>
    /// Provide coding and decoding of messages.
    /// For unified network communication is used standardized JSON format.
    /// </summary>
    public static class SocketManager
    {
        /// <summary>
        /// Transforms message to JSON format and then into array of bytes.
        /// Message types 
        /// </summary>
        public static byte[] MessageToSocket<messageType>(messageType mess)
        {
            string jsonCommand = JsonConvert.SerializeObject(mess);
            byte[] socket = Encoding.Unicode.GetBytes(jsonCommand);

            return socket;
        }
        
        /// <summary>
        /// Transforms array of bytes to JSON and then into the message.
        /// </summary>
        public static messageType SocketToMessage<messageType>(byte[] bytesBuffer)
        {
            string jsonMessage = Encoding.Unicode.GetString(bytesBuffer);

            messageType message = JsonConvert.DeserializeObject<messageType>(jsonMessage);

            return message;
        }
    }
}
