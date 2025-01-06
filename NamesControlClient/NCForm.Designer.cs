namespace NamesControlClient
{
    partial class NCForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            FstName = new DataGridViewButtonColumn();
            SndName = new DataGridViewTextBoxColumn();
            AddBut = new Button();
            RemoveBut = new Button();
            EditBut = new Button();
            FefreshTableBut = new Button();
            ManiPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ManiPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FstName, SndName });
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(864, 489);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FstName
            // 
            FstName.HeaderText = "First Name";
            FstName.MinimumWidth = 6;
            FstName.Name = "FstName";
            FstName.UseColumnTextForButtonValue = true;
            // 
            // SndName
            // 
            SndName.HeaderText = "Second Name";
            SndName.MinimumWidth = 6;
            SndName.Name = "SndName";
            // 
            // AddBut
            // 
            AddBut.Location = new Point(12, 12);
            AddBut.Name = "AddBut";
            AddBut.Size = new Size(125, 29);
            AddBut.TabIndex = 2;
            AddBut.Text = "Add New Name";
            AddBut.UseVisualStyleBackColor = true;
            AddBut.Click += AddBut_Click;
            // 
            // RemoveBut
            // 
            RemoveBut.Location = new Point(143, 12);
            RemoveBut.Name = "RemoveBut";
            RemoveBut.Size = new Size(125, 29);
            RemoveBut.TabIndex = 3;
            RemoveBut.Text = "Remove Name";
            RemoveBut.UseVisualStyleBackColor = true;
            // 
            // EditBut
            // 
            EditBut.Location = new Point(274, 12);
            EditBut.Name = "EditBut";
            EditBut.Size = new Size(125, 29);
            EditBut.TabIndex = 4;
            EditBut.Text = "Edit Name";
            EditBut.UseVisualStyleBackColor = true;
            // 
            // FefreshTableBut
            // 
            FefreshTableBut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FefreshTableBut.Location = new Point(751, 12);
            FefreshTableBut.Name = "FefreshTableBut";
            FefreshTableBut.Size = new Size(125, 29);
            FefreshTableBut.TabIndex = 5;
            FefreshTableBut.Text = "Refresh Table";
            FefreshTableBut.UseVisualStyleBackColor = true;
            // 
            // ManiPanel
            // 
            ManiPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManiPanel.Controls.Add(dataGridView1);
            ManiPanel.Location = new Point(0, 0);
            ManiPanel.Name = "ManiPanel";
            ManiPanel.Size = new Size(888, 548);
            ManiPanel.TabIndex = 6;
            // 
            // NCForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(888, 548);
            Controls.Add(FefreshTableBut);
            Controls.Add(EditBut);
            Controls.Add(RemoveBut);
            Controls.Add(AddBut);
            Controls.Add(ManiPanel);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(560, 140);
            Name = "NCForm";
            Text = "Names Control";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ManiPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn FstName;
        private DataGridViewTextBoxColumn SndName;
        private Button AddBut;
        private Button RemoveBut;
        private Button EditBut;
        private Button FefreshTableBut;
        private Panel ManiPanel;
    }
}
