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

        private void Add_Click(object sender, EventArgs e)
        {
            GuiEventHandler.AddNewNameHandler("Matej", "Novak");
        }
    }
}
