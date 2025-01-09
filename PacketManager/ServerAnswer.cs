using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlLib
{
    public struct ServerAnswer
    {
        public string? ErrorMessage { get; } = null;
        public (int, string, string)[] Grid { get; } = { };

        public ServerAnswer() { }
    }
}
