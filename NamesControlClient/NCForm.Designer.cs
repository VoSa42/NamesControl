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
            Add = new Button();
            Remove = new Button();
            Edit = new Button();
            FefreshTable = new Button();
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
            dataGridView1.Size = new Size(673, 293);
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
            // Add
            // 
            Add.Location = new Point(12, 12);
            Add.Name = "Add";
            Add.Size = new Size(125, 29);
            Add.TabIndex = 2;
            Add.Text = "Add new name";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(143, 12);
            Remove.Name = "Remove";
            Remove.Size = new Size(125, 29);
            Remove.TabIndex = 3;
            Remove.Text = "Remove Name";
            Remove.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            Edit.Location = new Point(274, 12);
            Edit.Name = "Edit";
            Edit.Size = new Size(125, 29);
            Edit.TabIndex = 4;
            Edit.Text = "Edit Name";
            Edit.UseVisualStyleBackColor = true;
            // 
            // FefreshTable
            // 
            FefreshTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FefreshTable.Location = new Point(560, 12);
            FefreshTable.Name = "FefreshTable";
            FefreshTable.Size = new Size(125, 29);
            FefreshTable.TabIndex = 5;
            FefreshTable.Text = "Refresh table";
            FefreshTable.UseVisualStyleBackColor = true;
            // 
            // ManiPanel
            // 
            ManiPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManiPanel.Controls.Add(dataGridView1);
            ManiPanel.Location = new Point(0, 0);
            ManiPanel.Name = "ManiPanel";
            ManiPanel.Size = new Size(697, 352);
            ManiPanel.TabIndex = 6;
            // 
            // NCForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(697, 352);
            Controls.Add(FefreshTable);
            Controls.Add(Edit);
            Controls.Add(Remove);
            Controls.Add(Add);
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
        private Button Add;
        private Button Remove;
        private Button Edit;
        private Button FefreshTable;
        private Panel ManiPanel;
    }
}
