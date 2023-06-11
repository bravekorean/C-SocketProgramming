namespace ServerForm
{
    partial class serverLogin
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
            panel1 = new Panel();
            sv_search = new Button();
            menu = new Button();
            search = new Button();
            CSmain = new Label();
            ID = new Label();
            input_ID = new TextBox();
            input_pass = new TextBox();
            pass = new Label();
            login_btn = new Button();
            Below_bar = new Panel();
            CStime_msg = new Label();
            CStime = new Label();
            panel1.SuspendLayout();
            Below_bar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(sv_search);
            panel1.Controls.Add(menu);
            panel1.Controls.Add(search);
            panel1.Controls.Add(CSmain);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 64);
            panel1.TabIndex = 6;
            // 
            // sv_search
            // 
            sv_search.BackgroundImage = Properties.Resources.검색_버튼;
            sv_search.BackgroundImageLayout = ImageLayout.Zoom;
            sv_search.FlatAppearance.BorderSize = 0;
            sv_search.FlatStyle = FlatStyle.Flat;
            sv_search.Location = new Point(891, 13);
            sv_search.Margin = new Padding(3, 3, 3, 0);
            sv_search.Name = "sv_search";
            sv_search.Size = new Size(35, 35);
            sv_search.TabIndex = 7;
            sv_search.UseVisualStyleBackColor = true;
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
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(303, 283);
            ID.Name = "ID";
            ID.Size = new Size(66, 25);
            ID.TabIndex = 9;
            ID.Text = "아이디";
            // 
            // input_ID
            // 
            input_ID.BackColor = SystemColors.MenuBar;
            input_ID.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_ID.Location = new Point(398, 280);
            input_ID.Name = "input_ID";
            input_ID.Size = new Size(297, 31);
            input_ID.TabIndex = 11;
            input_ID.Text = "f";
            input_ID.TextChanged += input_ID_TextChanged;
            // 
            // input_pass
            // 
            input_pass.BackColor = SystemColors.MenuBar;
            input_pass.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_pass.Location = new Point(398, 326);
            input_pass.Name = "input_pass";
            input_pass.Size = new Size(297, 31);
            input_pass.TabIndex = 13;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(291, 326);
            pass.Name = "pass";
            pass.Size = new Size(84, 25);
            pass.TabIndex = 12;
            pass.Text = "비밀번호";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.White;
            login_btn.BackgroundImage = Properties.Resources.로그인_버튼;
            login_btn.BackgroundImageLayout = ImageLayout.Zoom;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Location = new Point(469, 408);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(126, 54);
            login_btn.TabIndex = 14;
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Below_bar
            // 
            Below_bar.BackColor = SystemColors.Control;
            Below_bar.Controls.Add(CStime_msg);
            Below_bar.Controls.Add(CStime);
            Below_bar.Location = new Point(0, 611);
            Below_bar.Name = "Below_bar";
            Below_bar.Size = new Size(987, 54);
            Below_bar.TabIndex = 15;
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
            // serverLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(987, 665);
            Controls.Add(Below_bar);
            Controls.Add(login_btn);
            Controls.Add(input_pass);
            Controls.Add(pass);
            Controls.Add(input_ID);
            Controls.Add(ID);
            Controls.Add(panel1);
            Name = "serverLogin";
            Text = "serverForm";
            Load += serverLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Below_bar.ResumeLayout(false);
            Below_bar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button sv_search;
        private Button menu;
        private Button search;
        private Label CSmain;
        private Label ID;
        private TextBox input_ID;
        private TextBox input_pass;
        private Label pass;
        private Button login_btn;
        private Panel Below_bar;
        private Label CStime_msg;
        private Label CStime;
    }
}