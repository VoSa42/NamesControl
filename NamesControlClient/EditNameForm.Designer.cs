namespace NamesControlClient
{
    partial class EditNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EditNameSpec = new Label();
            textBox2 = new TextBox();
            FstNameLabel = new Label();
            SndNameLabel = new Label();
            FillFstName = new TextBox();
            FillSndName = new TextBox();
            EditNameConfirm = new Button();
            CancelBut = new Button();
            SuspendLayout();
            // 
            // EditNameSpec
            // 
            EditNameSpec.Anchor = AnchorStyles.None;
            EditNameSpec.AutoSize = true;
            EditNameSpec.Location = new Point(147, 58);
            EditNameSpec.Name = "EditNameSpec";
            EditNameSpec.Size = new Size(314, 20);
            EditNameSpec.TabIndex = 0;
            EditNameSpec.Text = "Fill in new name and press 'Edit Name' button:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // FstNameLabel
            // 
            FstNameLabel.Anchor = AnchorStyles.None;
            FstNameLabel.AutoSize = true;
            FstNameLabel.Location = new Point(178, 115);
            FstNameLabel.Name = "FstNameLabel";
            FstNameLabel.Size = new Size(83, 20);
            FstNameLabel.TabIndex = 8;
            FstNameLabel.Text = "First Name:";
            // 
            // SndNameLabel
            // 
            SndNameLabel.Anchor = AnchorStyles.None;
            SndNameLabel.AutoSize = true;
            SndNameLabel.Location = new Point(156, 148);
            SndNameLabel.Name = "SndNameLabel";
            SndNameLabel.Size = new Size(105, 20);
            SndNameLabel.TabIndex = 9;
            SndNameLabel.Text = "Second Name:";
            // 
            // FillFstName
            // 
            FillFstName.Anchor = AnchorStyles.None;
            FillFstName.Location = new Point(267, 112);
            FillFstName.Name = "FillFstName";
            FillFstName.Size = new Size(169, 27);
            FillFstName.TabIndex = 10;
            FillFstName.TextChanged += FillFstName_TextChanged;
            // 
            // FillSndName
            // 
            FillSndName.Anchor = AnchorStyles.None;
            FillSndName.Location = new Point(267, 145);
            FillSndName.Name = "FillSndName";
            FillSndName.Size = new Size(169, 27);
            FillSndName.TabIndex = 11;
            FillSndName.TextChanged += FillSndName_TextChanged;
            // 
            // EditNameConfirm
            // 
            EditNameConfirm.Anchor = AnchorStyles.None;
            EditNameConfirm.Location = new Point(167, 226);
            EditNameConfirm.Name = "EditNameConfirm";
            EditNameConfirm.Size = new Size(94, 29);
            EditNameConfirm.TabIndex = 12;
            EditNameConfirm.Text = "Edit Name";
            EditNameConfirm.UseVisualStyleBackColor = true;
            EditNameConfirm.Click += EditNameConfirm_Click;
            // 
            // CancelBut
            // 
            CancelBut.Anchor = AnchorStyles.None;
            CancelBut.Location = new Point(342, 226);
            CancelBut.Name = "CancelBut";
            CancelBut.Size = new Size(94, 29);
            CancelBut.TabIndex = 13;
            CancelBut.Text = "Cancel";
            CancelBut.UseVisualStyleBackColor = true;
            CancelBut.Click += CancelBut_Click;
            // 
            // EditNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 331);
            Controls.Add(CancelBut);
            Controls.Add(EditNameConfirm);
            Controls.Add(FillSndName);
            Controls.Add(FillFstName);
            Controls.Add(SndNameLabel);
            Controls.Add(FstNameLabel);
            Controls.Add(textBox2);
            Controls.Add(EditNameSpec);
            Name = "EditNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EditNameSpec;
        private TextBox textBox2;
        private Label FstNameLabel;
        private Label SndNameLabel;
        private TextBox FillFstName;
        private TextBox FillSndName;
        private Button EditNameConfirm;
        private Button CancelBut;
    }
}