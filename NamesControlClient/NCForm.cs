namespace NamesControlClient
{
    public partial class NCForm : Form
    {
        public NCForm()
        {
            InitializeComponent();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            var addNewF = new AddNewNameForm();
            addNewF.Show();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            var editNewF = new EditNameForm();
            editNewF.Show();
        }

        private void RemoveBut_Click(object sender, EventArgs e)
        {
            int dummyId = 42;

            GuiEventHandler.RemoveNameHandler(dummyId);
        }

        private void FefreshTableBut_Click(object sender, EventArgs e)
        {
            GuiEventHandler.RefreshHandler();
        }

        private void NamesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NamesDataGridView.Rows.Add(["Joe", "Dart"]);
        }
    }
}
