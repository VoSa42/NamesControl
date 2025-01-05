namespace NamesControlServer.ServerBackend
{
    internal struct Command
    {
        string command { get; set; }
        string? id { get; set; }
        string? firstName { get; set; }
        string? secondName { get; set; }

        public Command()
        {
            command = "";
            id = null;
            firstName = null;
            secondName = null;
        }

        public Command(string fullCommand)
        {
            var parsedCommand = fullCommand.Split('-');
            command = parsedCommand[0];
            id = parsedCommand[1];
            firstName = parsedCommand[2];
            secondName = parsedCommand[3];
        }
    }
}
