using Newtonsoft.Json;

namespace NamesControlLib.Messages
{
    public class Command(CommandType _command,
        string _firstName = "",
        string _secondName = "",
        int _id = -1) : Message
    {
        public CommandType command { get; set; } = _command;
        public string firstName { get; set; } = _firstName;
        public string secondName { get; set; } = _secondName;
        public int id { get; set; } = _id;

        public override string ToString()
        {
            return command + " "
                + firstName + " "
                + secondName + " "
                + id + " ";
        }
    }
}
