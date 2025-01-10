using Newtonsoft.Json;

namespace NamesControlLib.Messages
{
    public class Command : Message
    {
        public CommandType command { get; } = CommandType.None;
        public string firstName { get; } = string.Empty;
        public string secondName { get; } = string.Empty;
        public int id { get; } = -1;

        public Command(CommandType _command,
            string _firstName = "",
            string _secondName = "",
            int _id = -1)
        {
            command = _command;
            firstName = _firstName;
            secondName = _secondName;
            id = _id;
        }

        public override string ToString()
        {
            return command + " "
                + firstName + " "
                + secondName + " "
                + id + " ";
        }
    }
}
