namespace TCPpj_main
{
    partial class main
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
            QnA = new Button();
            CSR = new Button();
            panel1 = new Panel();
            menu = new Button();
            search = new Button();
            CSmain = new Label();
            Below_bar = new Panel();
            CStime_msg = new Label();
            CStime = new Label();
            login_msg = new Label();
            login_msg2 = new Label();
            login = new LinkLabel();
            panel1.SuspendLayout();
            Below_bar.SuspendLayout();
            SuspendLayout();
            // 
            // QnA
            // 
            QnA.BackgroundImage = Properties.Resources.QnA_버튼;
            QnA.BackgroundImageLayout = ImageLayout.Zoom;
            QnA.FlatAppearance.BorderSize = 0;
            QnA.FlatStyle = FlatStyle.Flat;
            QnA.Location = new Point(132, 160);
            QnA.Margin = new Padding(0);
            QnA.Name = "QnA";
            QnA.Size = new Size(321, 333);
            QnA.TabIndex = 2;
            QnA.UseVisualStyleBackColor = true;
            QnA.Click += QnA_Click;
            // 
            // CSR
            // 
            CSR.BackgroundImage = Properties.Resources.상담사연결_버튼;
            CSR.BackgroundImageLayout = ImageLayout.Zoom;
            CSR.FlatAppearance.BorderSize = 0;
            CSR.FlatStyle = FlatStyle.Flat;
            CSR.Location = new Point(536, 160);
            CSR.Margin = new Padding(4);
            CSR.Name = "CSR";
            CSR.Size = new Size(321, 333);
            CSR.TabIndex = 4;
            CSR.UseVisualStyleBackColor = true;
            CSR.Click += CSR_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(menu);
            panel1.Controls.Add(search);
            panel1.Controls.Add(CSmain);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 64);
            panel1.TabIndex = 5;
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
            CSmain.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CSmain.Location = new Point(10, 12);
            CSmain.Name = "CSmain";
            CSmain.Size = new Size(213, 38);
            CSmain.TabIndex = 1;
            CSmain.Text = "고객서비스센터";
            // 
            // Below_bar
            // 
            Below_bar.BackColor = SystemColors.Control;
            Below_bar.Controls.Add(CStime_msg);
            Below_bar.Controls.Add(CStime);
            Below_bar.Location = new Point(0, 611);
            Below_bar.Name = "Below_bar";
            Below_bar.Size = new Size(987, 54);
            Below_bar.TabIndex = 0;
            // 
            // CStime_msg
            // 
            CStime_msg.Location = new Point(3, 27);
            CStime_msg.Name = "CStime_msg";
            CStime_msg.Size = new Size(349, 23);
            CStime_msg.TabIndex = 0;
            CStime_msg.Text = "[실시간 채팅상담] 10:00~18:00 (점심 13:00~14:00)";
            // 
            // CStime
            // 
            CStime.AutoSize = true;
            CStime.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CStime.Location = new Point(3, 7);
            CStime.Name = "CStime";
            CStime.Size = new Size(134, 20);
            CStime.TabIndex = 0;
            CStime.Text = "고객센터 운영시간";
            // 
            // login_msg
            // 
            login_msg.AutoSize = true;
            login_msg.Location = new Point(722, 72);
            login_msg.Name = "login_msg";
            login_msg.Size = new Size(138, 20);
            login_msg.TabIndex = 6;
            login_msg.Text = "안녕하세요! 고객님";
            // 
            // login_msg2
            // 
            login_msg2.AutoSize = true;
            login_msg2.Location = new Point(905, 72);
            login_msg2.Name = "login_msg2";
            login_msg2.Size = new Size(72, 20);
            login_msg2.TabIndex = 7;
            login_msg2.Text = "해주세요.";
            login_msg2.Click += login_msg2_Click;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(855, 72);
            login.Name = "login";
            login.Size = new Size(54, 20);
            login.TabIndex = 8;
            login.TabStop = true;
            login.Text = "로그인";
            login.LinkClicked += login_LinkClicked;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(987, 665);
            Controls.Add(login);
            Controls.Add(login_msg2);
            Controls.Add(login_msg);
            Controls.Add(Below_bar);
            Controls.Add(panel1);
            Controls.Add(CSR);
            Controls.Add(QnA);
            Name = "main";
            Text = "main";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Below_bar.ResumeLayout(false);
            Below_bar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button QnA;
        private Button CSR;
        private Panel panel1;
        private Panel Below_bar;
        private Label CStime;
        private Label CStime_msg;
        private Label CSmain;
        private Button search;
        private Button menu;
        private Label login_msg;
        private Label login_msg2;
        private LinkLabel login;
    }
}