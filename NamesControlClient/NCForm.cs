using NamesControlLib;
using NamesControlLib.Messages;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace NamesControlClient
{
    public partial class NCForm : Form
    {
        //protected DataGrid DGrid { get; set; } = new([]);

        public NCForm()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            List<DatabaseRaw> table = LoadTable();
            BindAndUpdateTable(table);
        }

        private List<DatabaseRaw> LoadTable()
        {
            List<DatabaseRaw> table = GuiEventHandler.RefreshHandler().Grid;
            return table;
        }

        private void BindAndUpdateTable(List<DatabaseRaw> table)
        {
            BindingList<DatabaseRaw> bindedTable = new BindingList<DatabaseRaw>(table);

            NamesDataGridView.DataSource = bindedTable;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            var addNewF = new AddNewNameForm();
            addNewF.ShowDialog();
            RefreshTable();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            var editNewF = new EditNameForm();
            editNewF.Show();
        }

        private void RemoveBut_Click(object sender, EventArgs e)
        {
            int id = (int)NamesDataGridView.CurrentRow.Cells[0].Value;

            ServerAnswer answer = GuiEventHandler.RemoveNameHandler(id);
            BindAndUpdateTable(answer.Grid);
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
