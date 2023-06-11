namespace TCPpj_main
{
    partial class Loading
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
            Below_bar = new Panel();
            CStime_msg = new Label();
            CStime = new Label();
            loading_msg = new Label();
            progressBar1 = new ProgressBar();
            mungu = new Label();
            link_QnA = new LinkLabel();
            panel1.SuspendLayout();
            Below_bar.SuspendLayout();
            SuspendLayout();
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
            Below_bar.TabIndex = 7;
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
            // loading_msg
            // 
            loading_msg.AutoSize = true;
            loading_msg.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loading_msg.Location = new Point(322, 341);
            loading_msg.Name = "loading_msg";
            loading_msg.Size = new Size(323, 31);
            loading_msg.TabIndex = 8;
            loading_msg.Text = "지금 상담사와 연결중입니다~";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(300, 296);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(370, 29);
            progressBar1.TabIndex = 9;
            progressBar1.Click += progressBar1_Click;
            // 
            // mungu
            // 
            mungu.AutoSize = true;
            mungu.Location = new Point(782, 561);
            mungu.Name = "mungu";
            mungu.Size = new Size(191, 20);
            mungu.TabIndex = 10;
            mungu.Text = "상담사 연결이 안되시나요?";
            // 
            // link_QnA
            // 
            link_QnA.AutoSize = true;
            link_QnA.Location = new Point(839, 581);
            link_QnA.Name = "link_QnA";
            link_QnA.Size = new Size(134, 20);
            link_QnA.TabIndex = 11;
            link_QnA.TabStop = true;
            link_QnA.Text = "간편해결 보러가기";
            link_QnA.LinkClicked += link_QnA_LinkClicked;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(987, 665);
            Controls.Add(link_QnA);
            Controls.Add(mungu);
            Controls.Add(progressBar1);
            Controls.Add(loading_msg);
            Controls.Add(Below_bar);
            Controls.Add(panel1);
            Name = "Loading";
            Text = "Loading";
            Load += Loading_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Below_bar.ResumeLayout(false);
            Below_bar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menu;
        private Button search;
        private Label CSmain;
        private Panel Below_bar;
        private Label CStime_msg;
        private Label CStime;
        private Label loading_msg;
        private ProgressBar progressBar1;
        private Label mungu;
        private LinkLabel link_QnA;
    }
}