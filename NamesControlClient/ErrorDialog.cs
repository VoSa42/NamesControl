namespace NamesControlClient
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string label)
        {
            InitializeComponent();
            ErrorMessage.Text = label;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
