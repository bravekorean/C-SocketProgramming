namespace TCPpj_main
{
    partial class Server
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
            ServerPanel = new Panel();
            NoticeBox = new TextBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // ServerPanel
            // 
            ServerPanel.BackColor = Color.Honeydew;
            ServerPanel.Location = new Point(22, 25);
            ServerPanel.Name = "ServerPanel";
            ServerPanel.Size = new Size(756, 298);
            ServerPanel.TabIndex = 0;
            // 
            // NoticeBox
            // 
            NoticeBox.Location = new Point(22, 340);
            NoticeBox.Multiline = true;
            NoticeBox.Name = "NoticeBox";
            NoticeBox.Size = new Size(628, 80);
            NoticeBox.TabIndex = 0;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(684, 340);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 80);
            SendButton.TabIndex = 0;
            SendButton.Text = "보내기";
            SendButton.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(SendButton);
            Controls.Add(NoticeBox);
            Controls.Add(ServerPanel);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ServerPanel;
        private TextBox NoticeBox;
        private Button SendButton;
    }
}