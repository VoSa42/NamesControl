using System.Text.Json;

namespace NamesControlLib
{
    public struct Command
    {
        public CommandType command { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int id { get; set; }

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
            Console.WriteLine(jsonCommand);

            Command parsedCommand = JsonConvert.DeserializeObject<Command>(jsonCommand);

            this = parsedCommand;
        }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return command + " "
                + id + " "
                + firstName + " "
                + secondName + " "
                + id + " ";
        }
    }
}
