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
            var v = GuiEventHandler.AddNewNameHandler(FstName, SndName);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
