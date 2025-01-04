using System.Text;

namespace NamesControlLib
{
    public static class PacketManager
    {
        public static byte[] WrapCommand(string command)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(command);
            return buffer;
        }
        public static string UnwrapCommand(byte[] byteBuffer)
        {
            string command = Encoding.Unicode.GetString(byteBuffer);
            return command;
        }
    }
}
