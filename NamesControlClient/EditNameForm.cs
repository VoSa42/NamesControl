using NamesControlLib.Errors;
using NamesControlLib.Messages;

namespace NamesControlClient
{
    /// <summary>
    /// Dialog window to realize editing selected name in database.
    /// </summary>
    public partial class EditNameForm : Form
    {
        private string FstName { get; set; } = string.Empty;
        private string SndName { get; set; } = string.Empty;
        private int Id {  get; set; }

        public EditNameForm(int selectedId, string selectedFstName, string selectedSndName)
        {
            Id = selectedId;
            FstName = selectedFstName;
            SndName = selectedSndName;

            InitializeComponent();

            FillFstName.Text = FstName;
            FillSndName.Text = SndName;
        }

        private void FillFstName_TextChanged(object sender, EventArgs e)
        {
            FstName = FillFstName.Text;
        }

        private void FillSndName_TextChanged(object sender, EventArgs e)
        {
            SndName = FillSndName.Text;
        }

        /// <summary>
        /// Provides the 'edit name' process
        /// </summary>
        private void EditNameConfirm_Click(object sender, EventArgs e)
        {
            ServerResponse answer = GuiEventHandler.EditNameHandler(Id, FstName, SndName);
            
            ErrorType error = answer.ErrorType;

            DialogResult = DialogResult.OK;
            Close();

            if (error == ErrorType.RecordNotExist)
            {
                ErrorDialog errorDialog = new(ErrorMessages.GetErrorMessage(error));
                errorDialog.ShowDialog();
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
