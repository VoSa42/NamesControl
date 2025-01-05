namespace NamesControlServer.ServerBackend
{
    internal struct Command
    {
        public string command { get;}
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

            if (parsedCommand.Length == 4)
            {
                id = parsedCommand[1];
                firstName = parsedCommand[2];
                secondName = parsedCommand[3];
            }
        }
    }
}
