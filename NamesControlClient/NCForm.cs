namespace NamesControlClient
{
    public partial class NCForm : Form
    {
        public NCForm()
        {
            InitializeComponent();
        }

        private void SenMessage_Click(object sender, EventArgs e)
        {
            GuiEventHandler.TestClickHandler();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
