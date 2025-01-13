using System.ComponentModel;

using NamesControlLib;

namespace NamesControlClient
{
    public class DataGrid(BindingList<NamesTableRow> grid)
    {
        public BindingList<NamesTableRow> Grid { get; set; } = grid;
    }
}
