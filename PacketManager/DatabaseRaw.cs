using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlLib
{
    public readonly struct DatabaseRaw(int id, string firstName, string secondName)
    {
        public int Id { get; } = id;
        public string FirstName { get; } =  firstName;
        public string SecondName { get; } = secondName;
    }
}
