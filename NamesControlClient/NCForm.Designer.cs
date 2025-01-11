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
            components = new System.ComponentModel.Container();
            NamesDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secondNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gridBindingSource = new BindingSource(components);
            dataGridBindingSource = new BindingSource(components);
            AddBut = new Button();
            RemoveBut = new Button();
            EditBut = new Button();
            FefreshTableBut = new Button();
            ManiPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBindingSource).BeginInit();
            ManiPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NamesDataGridView
            // 
            NamesDataGridView.AllowUserToAddRows = false;
            NamesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NamesDataGridView.AutoGenerateColumns = false;
            NamesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, secondNameDataGridViewTextBoxColumn });
            NamesDataGridView.DataSource = gridBindingSource;
            NamesDataGridView.Location = new Point(12, 47);
            NamesDataGridView.Name = "NamesDataGridView";
            NamesDataGridView.RowHeadersWidth = 51;
            NamesDataGridView.Size = new Size(864, 489);
            NamesDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            secondNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridBindingSource
            // 
            gridBindingSource.DataMember = "Grid";
            gridBindingSource.DataSource = dataGridBindingSource;
            // 
            // dataGridBindingSource
            // 
            dataGridBindingSource.DataSource = typeof(DataGrid);
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
            RemoveBut.Click += RemoveBut_Click;
            // 
            // EditBut
            // 
            EditBut.Location = new Point(274, 12);
            EditBut.Name = "EditBut";
            EditBut.Size = new Size(125, 29);
            EditBut.TabIndex = 4;
            EditBut.Text = "Edit Name";
            EditBut.UseVisualStyleBackColor = true;
            EditBut.Click += EditBut_Click;
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
            FefreshTableBut.Click += FefreshTableBut_Click;
            // 
            // ManiPanel
            // 
            ManiPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManiPanel.Controls.Add(NamesDataGridView);
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
            Load += NCForm_Load;
            ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBindingSource).EndInit();
            ManiPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView NamesDataGridView;
        private Button AddBut;
        private Button RemoveBut;
        private Button EditBut;
        private Button FefreshTableBut;
        private Panel ManiPanel;
        private DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private BindingSource dataGridBindingSource;
        private BindingSource gridBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
    }
}
