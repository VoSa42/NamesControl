using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlClient
{
    public class DataGrid
    {
        public BindingList<DatabaseRaw> Grid { get; set; } = new BindingList<DatabaseRaw>();

        public DataGrid(BindingList<DatabaseRaw> grid)
        {
            Grid = grid;
        }
    }
}
