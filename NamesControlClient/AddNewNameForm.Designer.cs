namespace NamesControlClient
{
    partial class AddNewNameForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddNameSpec = new Label();
            AddNameConfirm = new Button();
            FillFstName = new TextBox();
            FstNameLabel = new Label();
            SndNameLabel = new Label();
            FillSndName = new TextBox();
            CancelBut = new Button();
            SuspendLayout();
            // 
            // AddNameSpec
            // 
            AddNameSpec.Anchor = AnchorStyles.None;
            AddNameSpec.AutoSize = true;
            AddNameSpec.Location = new Point(147, 58);
            AddNameSpec.Name = "AddNameSpec";
            AddNameSpec.Size = new Size(316, 20);
            AddNameSpec.TabIndex = 0;
            AddNameSpec.Text = "Fill in new name and press 'Add Name' button:";
            // 
            // AddNameConfirm
            // 
            AddNameConfirm.Anchor = AnchorStyles.None;
            AddNameConfirm.Location = new Point(167, 226);
            AddNameConfirm.Name = "AddNameConfirm";
            AddNameConfirm.Size = new Size(94, 29);
            AddNameConfirm.TabIndex = 1;
            AddNameConfirm.Text = "Add Name";
            AddNameConfirm.UseVisualStyleBackColor = true;
            AddNameConfirm.Click += AddNameConfirm_Click;
            // 
            // FillFstName
            // 
            FillFstName.Anchor = AnchorStyles.None;
            FillFstName.Location = new Point(267, 112);
            FillFstName.Name = "FillFstName";
            FillFstName.Size = new Size(169, 27);
            FillFstName.TabIndex = 2;
            FillFstName.TextChanged += FillFstName_TextChanged;
            // 
            // FstNameLabel
            // 
            FstNameLabel.Anchor = AnchorStyles.None;
            FstNameLabel.AutoSize = true;
            FstNameLabel.Location = new Point(178, 115);
            FstNameLabel.Name = "FstNameLabel";
            FstNameLabel.Size = new Size(83, 20);
            FstNameLabel.TabIndex = 3;
            FstNameLabel.Text = "First Name:";
            // 
            // SndNameLabel
            // 
            SndNameLabel.Anchor = AnchorStyles.None;
            SndNameLabel.AutoSize = true;
            SndNameLabel.Location = new Point(156, 148);
            SndNameLabel.Name = "SndNameLabel";
            SndNameLabel.Size = new Size(105, 20);
            SndNameLabel.TabIndex = 4;
            SndNameLabel.Text = "Second Name:";
            // 
            // FillSndName
            // 
            FillSndName.Anchor = AnchorStyles.None;
            FillSndName.Location = new Point(267, 145);
            FillSndName.Name = "FillSndName";
            FillSndName.Size = new Size(169, 27);
            FillSndName.TabIndex = 5;
            FillSndName.TextChanged += FillSndName_TextChanged;
            // 
            // CancelBut
            // 
            CancelBut.Anchor = AnchorStyles.None;
            CancelBut.Location = new Point(342, 226);
            CancelBut.Name = "CancelBut";
            CancelBut.Size = new Size(94, 29);
            CancelBut.TabIndex = 6;
            CancelBut.Text = "Cancel";
            CancelBut.UseVisualStyleBackColor = true;
            CancelBut.Click += CancelBut_Click;
            // 
            // AddNewNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 331);
            Controls.Add(CancelBut);
            Controls.Add(FillSndName);
            Controls.Add(SndNameLabel);
            Controls.Add(FstNameLabel);
            Controls.Add(FillFstName);
            Controls.Add(AddNameConfirm);
            Controls.Add(AddNameSpec);
            Name = "AddNewNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNameSpec;
        private Button AddNameConfirm;
        private TextBox FillFstName;
        private Label FstNameLabel;
        private Label SndNameLabel;
        private TextBox FillSndName;
        private Button CancelBut;
    }
}
