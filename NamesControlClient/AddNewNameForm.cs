namespace NamesControlClient
{
    /// <summary>
    /// Dialog window to realize adding new name to database.
    /// </summary>
    public partial class AddNewNameForm : Form
    {
        private string FstName = string.Empty;
        private string SndName = string.Empty;

        public AddNewNameForm()
        {
            InitializeComponent();
        }

        private void FillFstName_TextChanged(object sender, EventArgs e)
        {
            FstName = FillFstName.Text;
        }

        private void FillSndName_TextChanged(object sender, EventArgs e)
        {
            SndName = FillSndName.Text;
        }

        private void AddNameConfirm_Click(object sender, EventArgs e)
        {
            _ = GuiEventHandler.AddNewNameHandler(FstName, SndName);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
