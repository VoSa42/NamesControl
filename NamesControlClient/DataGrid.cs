using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlClient
{
    public class DataGrid(BindingList<DatabaseRaw> grid)
    {
        public BindingList<DatabaseRaw> Grid { get; set; } = grid;
    }
}
