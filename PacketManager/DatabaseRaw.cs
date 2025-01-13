namespace NamesControlLib
{
    public readonly struct DatabaseRaw(int id, string firstName, string secondName)
    {
        public int Id { get; } = id;
        public string FirstName { get; } =  firstName;
        public string SecondName { get; } = secondName;
    }
}
