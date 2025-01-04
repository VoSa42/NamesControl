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
            SenMessage = new Button();
            SuspendLayout();
            // 
            // SenMessage
            // 
            SenMessage.Location = new Point(203, 127);
            SenMessage.Name = "SenMessage";
            SenMessage.Size = new Size(124, 29);
            SenMessage.TabIndex = 0;
            SenMessage.Text = "Send Message";
            SenMessage.UseVisualStyleBackColor = true;
            SenMessage.Click += SenMessage_Click;
            // 
            // NCForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SenMessage);
            Name = "NCForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Names Control";
            ResumeLayout(false);
        }

        #endregion

        private Button SenMessage;
    }
}
