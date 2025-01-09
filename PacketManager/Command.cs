using System.Text.Json;

namespace NamesControlLib
{
    public struct Command
    {
        public string command { get; }
        public int id { get; }
        public string firstName { get; }
        public string secondName { get; }

        public Command()
        {
            command = "";
            id = -1;
            firstName = "";
            secondName = "";
        }

        public Command(string _command, int _id, string _firstName, string _secondName)
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
