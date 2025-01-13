using System.ComponentModel;

using NamesControlLib;

namespace NamesControlClient
{
    public class DataGrid(BindingList<DatabaseRaw> grid)
    {
        public BindingList<DatabaseRaw> Grid { get; set; } = grid;
    }
}
