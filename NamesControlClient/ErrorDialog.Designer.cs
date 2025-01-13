namespace NamesControlClient
{
    partial class ErrorDialog
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
            ErrorMessage = new Label();
            Ok = new Button();
            SuspendLayout();
            // 
            // ErrorMessage
            // 
            ErrorMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ErrorMessage.AutoSize = true;
            ErrorMessage.Location = new Point(226, 63);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(41, 20);
            ErrorMessage.TabIndex = 0;
            ErrorMessage.Text = "Error";
            ErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ok
            // 
            Ok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ok.Location = new Point(201, 131);
            Ok.Name = "Ok";
            Ok.Size = new Size(94, 29);
            Ok.TabIndex = 1;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // ErrorDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 225);
            Controls.Add(Ok);
            Controls.Add(ErrorMessage);
            Name = "ErrorDialog";
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorMessage;
        private Button Ok;
    }
}