using System.Text;
using System.Text.Json;

namespace NamesControlLib
{
    public static class PacketManager
    {
        public static byte[] StringToJson(string command)
        {
            string jsonCommand = JsonSerializer.Serialize(command);
            byte[] message = Encoding.Unicode.GetBytes(jsonCommand);

            return message;
        }

        public static string JsonToString(byte[] bytesBuffer)
        {
            string message = Encoding.Unicode.GetString(bytesBuffer);

            string jsonCommand = "";

            foreach (var readChar in message)
            {
                if (readChar != '\0')
                {
                    jsonCommand += readChar;
                }
            }

            string command = JsonSerializer.Deserialize<string>(jsonCommand);
            
            return command;
        }
    }
}
