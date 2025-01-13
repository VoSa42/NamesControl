namespace NamesControlLib.Messages
{
    /// <summary>
    /// Represents command as commands type and its attributes.
    /// </summary>
    public class Command(CommandType commandName,
        string firstName = "",
        string secondName = "",
        int id = -1) : Message
    {
        public CommandType CommandName { get; set; } = commandName;
        public string FirstName { get; set; } = firstName;
        public string SecondName { get; set; } = secondName;
        public int Id { get; set; } = id;

        public override string ToString()
        {
            return CommandName + " "
                + FirstName + " "
                + SecondName + " "
                + Id + " ";
        }
    }
}
