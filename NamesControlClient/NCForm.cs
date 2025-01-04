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
    }
}
