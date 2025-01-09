namespace NamesControlLib
{
    public struct Command
    {
        public string command { get; }
        public string? id { get; }
        public string? firstName { get; }
        public string? secondName { get; }

        public Command()
        {
            command = "";
            id = null;
            firstName = null;
            secondName = null;
        }

        public Command(string fullCommand) : this()
        {
            var parsedCommand = fullCommand.Split('-');

            if (parsedCommand.Length > 0)
            {
                command = parsedCommand[0];
            }

            if (command == "add")
            {
                firstName = parsedCommand[1];
                secondName = parsedCommand[2];
            }

            if (command == "edit" || command == "remove")
            {
                id = parsedCommand[1];
                firstName = parsedCommand[2];
                secondName = parsedCommand[3];
            }
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
