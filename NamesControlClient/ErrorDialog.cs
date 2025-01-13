namespace NamesControlClient
{
    /// <summary>
    /// Simple error dialog window.
    /// Gives the user info about detected error.
    /// </summary>
    public partial class ErrorDialog : Form
    {
        /// <summary>
        /// Primary initializing.
        /// </summary>
        /// <param name="label"></param>
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
