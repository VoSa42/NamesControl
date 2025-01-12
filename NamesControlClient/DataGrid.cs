using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NamesControlLib;

namespace NamesControlClient
{
    // TODO: Proc tady neni videt typ BindedType ze souboru NCForm, kdyz je to stejny namespace?
    public class DataGrid(BindingList<DatabaseRaw> grid)
    {
        public BindingList<DatabaseRaw> Grid { get; set; } = grid;
    }
}
