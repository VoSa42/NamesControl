namespace NamesControlClient
{
    public partial class NCForm : Form
    {
        public NCForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
