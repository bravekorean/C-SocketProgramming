namespace TCPpj_main
{
    partial class login
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
            ID = new Label();
            pass = new Label();
            input_ID = new TextBox();
            input_pass = new TextBox();
            login_btn = new Button();
            joinlink = new LinkLabel();
            panel1.SuspendLayout();
            Below_bar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
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
            menu.Click += menu_Click;
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
            search.Click += search_Click;
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
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(306, 279);
            ID.Name = "ID";
            ID.Size = new Size(66, 25);
            ID.TabIndex = 8;
            ID.Text = "아이디";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(288, 326);
            pass.Name = "pass";
            pass.Size = new Size(84, 25);
            pass.TabIndex = 9;
            pass.Text = "비밀번호";
            // 
            // input_ID
            // 
            input_ID.BackColor = SystemColors.MenuBar;
            input_ID.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_ID.Location = new Point(395, 276);
            input_ID.Name = "input_ID";
            input_ID.Size = new Size(297, 31);
            input_ID.TabIndex = 10;
            input_ID.TextChanged += input_ID_TextChanged;
            // 
            // input_pass
            // 
            input_pass.BackColor = SystemColors.MenuBar;
            input_pass.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_pass.Location = new Point(395, 326);
            input_pass.Name = "input_pass";
            input_pass.Size = new Size(297, 31);
            input_pass.TabIndex = 11;
            input_pass.TextChanged += input_pass_TextChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.White;
            login_btn.BackgroundImage = Properties.Resources.로그인_버튼1;
            login_btn.BackgroundImageLayout = ImageLayout.Zoom;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Location = new Point(461, 385);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(126, 54);
            login_btn.TabIndex = 12;
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // joinlink
            // 
            joinlink.AutoSize = true;
            joinlink.Location = new Point(436, 475);
            joinlink.Name = "joinlink";
            joinlink.Size = new Size(176, 20);
            joinlink.TabIndex = 13;
            joinlink.TabStop = true;
            joinlink.Text = "아직 회원이 아니신가요?";
            joinlink.LinkClicked += joinlink_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(987, 665);
            Controls.Add(joinlink);
            Controls.Add(login_btn);
            Controls.Add(input_pass);
            Controls.Add(input_ID);
            Controls.Add(pass);
            Controls.Add(ID);
            Controls.Add(Below_bar);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
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
        private Label ID;
        private Label pass;
        private TextBox input_ID;
        private TextBox input_pass;
        private Button login_btn;
        private LinkLabel joinlink;
    }
}