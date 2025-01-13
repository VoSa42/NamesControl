using System.ComponentModel;

using NamesControlLib;

namespace NamesControlClient
{
    /// <summary>
    /// Represents data grid binded to be used in DataGriView.
    /// </summary>
    /// <param name="grid">
    /// Table represents the same table as on the remote server side database.
    /// </param>
    public class DataGrid(BindingList<NamesTableRow> grid)
    {
        public BindingList<NamesTableRow> Grid { get; set; } = grid;
    }
}
