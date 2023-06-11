namespace TCPpj_main
{
    partial class ClientWin
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
            panel1 = new Panel();
            menu = new Button();
            search = new Button();
            CSmain = new Label();
            textBox1 = new TextBox();
            msgSend = new Button();
            imgSend = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(menu);
            panel1.Controls.Add(search);
            panel1.Controls.Add(CSmain);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 50);
            panel1.TabIndex = 6;
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.BackgroundImage = Properties.Resources.더보기_버튼;
            menu.BackgroundImageLayout = ImageLayout.Zoom;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Location = new Point(932, 10);
            menu.Name = "menu";
            menu.Size = new Size(40, 40);
            menu.TabIndex = 6;
            menu.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.BackgroundImage = Properties.Resources.검색_버튼;
            search.BackgroundImageLayout = ImageLayout.Zoom;
            search.FlatAppearance.BorderSize = 0;
            search.FlatStyle = FlatStyle.Flat;
            search.Location = new Point(885, 11);
            search.Margin = new Padding(3, 3, 3, 0);
            search.Name = "search";
            search.Size = new Size(35, 35);
            search.TabIndex = 6;
            search.UseVisualStyleBackColor = true;
            // 
            // CSmain
            // 
            CSmain.AutoSize = true;
            CSmain.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CSmain.Location = new Point(3, 8);
            CSmain.Name = "CSmain";
            CSmain.Size = new Size(175, 31);
            CSmain.TabIndex = 1;
            CSmain.Text = "고객서비스센터";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 559);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 44);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // msgSend
            // 
            msgSend.BackColor = SystemColors.ControlLightLight;
            msgSend.BackgroundImage = Properties.Resources.보내기_버튼;
            msgSend.BackgroundImageLayout = ImageLayout.Zoom;
            msgSend.Location = new Point(432, 559);
            msgSend.Name = "msgSend";
            msgSend.Size = new Size(50, 44);
            msgSend.TabIndex = 8;
            msgSend.UseVisualStyleBackColor = false;
            msgSend.Click += msgSend_Click;
            // 
            // imgSend
            // 
            imgSend.BackColor = SystemColors.Window;
            imgSend.BackgroundImage = Properties.Resources.사진보내기_버튼;
            imgSend.BackgroundImageLayout = ImageLayout.Zoom;
            imgSend.Location = new Point(0, 559);
            imgSend.Name = "imgSend";
            imgSend.Size = new Size(48, 44);
            imgSend.TabIndex = 9;
            imgSend.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(458, 486);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // ClientWin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(482, 603);
            Controls.Add(richTextBox1);
            Controls.Add(imgSend);
            Controls.Add(msgSend);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "ClientWin";
            Text = "ClientWin";
            Load += ClientWin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menu;
        private Button search;
        private Label CSmain;
        private TextBox textBox1;
        private Button msgSend;
        private Button imgSend;
        private RichTextBox richTextBox1;
    }
}