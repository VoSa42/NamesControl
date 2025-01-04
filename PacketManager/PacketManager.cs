using System.Text;

namespace NamesControlLib
{
    public static class PacketManager
    {
        public static byte[] WrapCommand(string command)
        {
            byte[] message = Encoding.UTF32.GetBytes(command);
            return message;
        }
        public static string UnwrapCommand(byte[] bytesBuffer)
        {

            string message = Encoding.Unicode.GetString(bytesBuffer);
            string command = "";

            foreach (var readChar in message)
            {
                if (readChar != '\0')
                {
                    command += readChar;
                }
            }
            return command;
        }
    }
}
