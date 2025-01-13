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
