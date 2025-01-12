﻿using System;
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
        private string fstName = string.Empty;
        private string sndName = string.Empty;
        private int id;

        public EditNameForm(int selectedId)
        {
            id = selectedId;
            InitializeComponent();
        }

        private void FillFstName_TextChanged(object sender, EventArgs e)
        {
            fstName = FillFstName.Text;
        }

        private void FillSndName_TextChanged(object sender, EventArgs e)
        {
            sndName = FillSndName.Text;
        }

        private void EditNameConfirm_Click(object sender, EventArgs e)
        {
            GuiEventHandler.EditNameHandler(id, fstName, sndName);

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
