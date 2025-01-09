using System.Text.Json;

namespace NamesControlLib
{
    public struct Command
    {
        public CommandType command { get; }
        public int id { get; }
        public string firstName { get; }
        public string secondName { get; }

        public Command() : this(CommandType.None) { }

        public Command(CommandType _command,
            string _firstName = "",
            string _secondName = "",
            int _id = -1)
        {
            command = _command;
            id = _id;
            firstName = _firstName;
            secondName = _secondName;
        }

        public Command(string jsonCommand) : this()
        {
            Command parsedCommand = JsonSerializer.Deserialize<Command>(jsonCommand);
            this = parsedCommand;
        }

        public string GetJson()
        {
            return JsonSerializer.Serialize<Command>(this);
        }

        public override string ToString()
        {
            return command + " "
                + id + " "
                + firstName + " "
                + secondName + " ";
        }
    }
}
