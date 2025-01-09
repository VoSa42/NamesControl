using System.Text.Json;
using Newtonsoft;
using Newtonsoft.Json;

namespace NamesControlLib
{
    public struct Command
    {
        public CommandType command { get; set; } = CommandType.None;
        public string firstName { get; set; } = string.Empty;
        public string secondName { get; set; } = string.Empty;
        public int id { get; set; } = -1;

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

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
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
