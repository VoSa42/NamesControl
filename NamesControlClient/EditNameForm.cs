using NamesControlClient.Errors;
using NamesControlLib.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamesControlClient
{
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

        private void EditNameConfirm_Click(object sender, EventArgs e)
        {
            ServerAnswer answer = GuiEventHandler.EditNameHandler(Id, FstName, SndName);
            
            ErrorType error = answer.ErrorType;
            if (error == ErrorType.RecordNotExist)
            {
                ErrorDialog errorDialog = new(ErrorMessages.GetErrorMessage(answer.ErrorType));
            }

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
