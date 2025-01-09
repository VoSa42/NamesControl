using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace NamesControlLib
{
    public static class SocketManager
    {
        public static byte[] CommandToMessage(Command command)
        {
            string jsonCommand = command.GetJson();
            byte[] message = Encoding.Unicode.GetBytes(jsonCommand);

            return message;
        }

        public static Command MessageToCommand(byte[] bytesBuffer)
        {
            string jsonMessage = Encoding.Unicode.GetString(bytesBuffer);

            Command com = JsonConvert.DeserializeObject<Command>(jsonMessage);

            return com;
        }
    }
}
