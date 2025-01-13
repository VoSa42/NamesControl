using NamesControlClient.Errors;
using NamesControlLib;
using NamesControlLib.Messages;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace NamesControlClient
{
    using Table = List<DatabaseRaw>;
    using BindedTable = BindingList<DatabaseRaw>;
    public partial class NCForm : Form
    {
        public NCForm()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            Table table = LoadTable();
            BindAndUpdateTable(table);
        }

        private static Table? LoadTable()
        {
            Table table = GuiEventHandler.RefreshHandler().Grid;
            return table;
        }

        private void BindAndUpdateTable(Table? table)
        {
            if (table != null)
            {
                BindedTable bindedTable = new(table);
                NamesDataGridView.DataSource = bindedTable;
            }
        }

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

        private void RemoveBut_Click(object sender, EventArgs e)
        {
            int selectedId = (int)NamesDataGridView.CurrentRow.Cells[0].Value;

            ServerAnswer answer = GuiEventHandler.RemoveNameHandler(selectedId);

            ErrorType error = answer.ErrorType;
            if (error == ErrorType.RecordNotExist)
            {
                ErrorDialog errorDialog = new(ErrorMessages.GetErrorMessage(answer.ErrorType));
            }

            BindAndUpdateTable(answer.Grid);
        }

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

        private void FefreshTableBut_Click(object sender, EventArgs e)
        {
            ServerAnswer answer = GuiEventHandler.RefreshHandler();
            BindAndUpdateTable(answer.Grid);
        }

        private void NCForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
