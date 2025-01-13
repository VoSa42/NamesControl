using NamesControlLib;
using NamesControlLib.Errors;
using NamesControlLib.Messages;
using System.ComponentModel;

namespace NamesControlClient
{
    using Table = List<NamesTableRow>;
    using BindedTable = BindingList<NamesTableRow>;

    /// <summary>
    /// Main window.
    /// This form implicitly shows after client application starts.
    /// All the control logic starts in this class.
    /// </summary>
    public partial class NCForm : Form
    {
        /// <summary>
        /// Primary initializing.
        /// </summary>
        public NCForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load and update table (DataGridView).
        /// </summary>
        private void RefreshTable()
        {
            Table? table = LoadTable();
            BindAndUpdateTable(table);
        }

        /// <summary>
        /// Loads current state of table from remote database.
        /// </summary>
        private static Table? LoadTable()
        {
            Table? table = GuiEventHandler.RefreshHandler().Grid;
            return table;
        }

        /// <summary>
        /// Can bind and show the fresh state of table.
        /// </summary>
        private void BindAndUpdateTable(Table? table)
        {
            if (table != null)
            {
                BindedTable bindedTable = new(table);
                NamesDataGridView.DataSource = bindedTable;
            }
        }

        /// <summary>
        /// Shows dialog window with 'add name' options.
        /// </summary>
        private void AddBut_Click(object sender, EventArgs e)
        {
            var addNewF = new AddNewNameForm();
            addNewF.ShowDialog();

            // Useless extra requesting server
            // -> TODO: get grid from server answer
            //      - problem is that the ansver is lost in 'addNewF' dialog
            //
            // Note: On the other hand this can be usefull when 'Cancel' button is clicked,
            // the dataGrid is updated anyway
            RefreshTable();
        }

        /// <summary>
        /// Removes currently selected name from table
        /// </summary>
        private void RemoveBut_Click(object sender, EventArgs e)
        {
            int selectedId = (int)NamesDataGridView.CurrentRow.Cells[0].Value;

            ServerResponse answer = GuiEventHandler.RemoveNameHandler(selectedId);

            ErrorType error = answer.ErrorType;
            if (error == ErrorType.RecordNotExist)
            {
                ErrorDialog errorDialog = new(ErrorMessages.GetErrorMessage(answer.ErrorType));
                errorDialog.ShowDialog();
            }

            BindAndUpdateTable(answer.Grid);
        }

        /// <summary>
        /// Shows dialog window with 'edit name' options.
        /// Only currently selected name from DataGriView is edited
        /// </summary>
        private void EditBut_Click(object sender, EventArgs e)
        {
            int selectedId = (int)NamesDataGridView.CurrentRow.Cells[0].Value;
            string selectedFstName = (string)NamesDataGridView.CurrentRow.Cells[1].Value;
            string selectedSndName = (string)NamesDataGridView.CurrentRow.Cells[2].Value;

            var editNewF = new EditNameForm(selectedId, selectedFstName, selectedSndName);
            editNewF.ShowDialog();

            // Useless extra requesting server
            // -> TODO: get grid from server answer
            //      - problem is that the ansver is lost in 'editNewF' dialog
            //
            // Note: On the other hand this can be usefull when 'Cancel' button is clicked,
            // the dataGrid is updated anyway
            RefreshTable();
        }

        /// <summary>
        /// Refresh DataGridView
        /// </summary>
        private void FefreshTableBut_Click(object sender, EventArgs e)
        {
            ServerResponse answer = GuiEventHandler.RefreshHandler();
            BindAndUpdateTable(answer.Grid);
        }

        private void NCForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
