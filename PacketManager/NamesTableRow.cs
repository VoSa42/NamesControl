﻿namespace NamesControlLib
{
    /// <summary>
    /// Represents one record in database table Names
    /// </summary>
    public readonly struct NamesTableRow(int id, string firstName, string secondName)
    {
        public int Id { get; } = id;
        public string FirstName { get; } =  firstName;
        public string SecondName { get; } = secondName;
    }
}
