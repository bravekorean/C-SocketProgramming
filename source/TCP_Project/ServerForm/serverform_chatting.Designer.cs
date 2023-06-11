namespace ServerForm
{
    partial class serverform_chatting
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
            sv_search = new Button();
            menu = new Button();
            search = new Button();
            CSmain = new Label();
            Below_bar = new Panel();
            CStime_msg = new Label();
            CStime = new Label();
            customer_information = new Panel();
            label1 = new Label();
            customer_info = new Label();
            panel9 = new Panel();
            panel8 = new Panel();
            listView1 = new ListView();
            panel7 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            chatterbox = new Label();
            panel6 = new Panel();
            imgSend = new Button();
            msgSend = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();
            richTextBox1 = new RichTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            Below_bar.SuspendLayout();
            customer_information.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 80);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // sv_search
            // 
            sv_search.BackgroundImage = Properties.Resources.검색_버튼;
            sv_search.BackgroundImageLayout = ImageLayout.Zoom;
            sv_search.FlatAppearance.BorderSize = 0;
            sv_search.FlatStyle = FlatStyle.Flat;
            sv_search.Location = new Point(990, 16);
            sv_search.Margin = new Padding(3, 4, 3, 0);
            sv_search.Name = "sv_search";
            sv_search.Size = new Size(39, 44);
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
            menu.Location = new Point(1036, 12);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(44, 50);
            menu.TabIndex = 6;
            menu.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.BackgroundImageLayout = ImageLayout.Zoom;
            search.FlatAppearance.BorderSize = 0;
            search.FlatStyle = FlatStyle.Flat;
            search.Location = new Point(983, 14);
            search.Margin = new Padding(3, 4, 3, 0);
            search.Name = "search";
            search.Size = new Size(39, 44);
            search.TabIndex = 6;
            search.UseVisualStyleBackColor = true;
            // 
            // CSmain
            // 
            CSmain.AutoSize = true;
            CSmain.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CSmain.Location = new Point(11, 15);
            CSmain.Name = "CSmain";
            CSmain.Size = new Size(251, 45);
            CSmain.TabIndex = 1;
            CSmain.Text = "고객서비스센터";
            // 
            // Below_bar
            // 
            Below_bar.BackColor = SystemColors.Control;
            Below_bar.Controls.Add(CStime_msg);
            Below_bar.Controls.Add(CStime);
            Below_bar.Location = new Point(0, 764);
            Below_bar.Margin = new Padding(3, 4, 3, 4);
            Below_bar.Name = "Below_bar";
            Below_bar.Size = new Size(1097, 68);
            Below_bar.TabIndex = 16;
            // 
            // CStime_msg
            // 
            CStime_msg.Location = new Point(3, 34);
            CStime_msg.Name = "CStime_msg";
            CStime_msg.Size = new Size(388, 29);
            CStime_msg.TabIndex = 0;
            CStime_msg.Text = "[실시간 채팅상담] 10:00~18:00 (점심 13:00~14:00)";
            // 
            // CStime
            // 
            CStime.AutoSize = true;
            CStime.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CStime.Location = new Point(3, 9);
            CStime.Name = "CStime";
            CStime.Size = new Size(162, 25);
            CStime.TabIndex = 0;
            CStime.Text = "고객센터 운영시간";
            // 
            // customer_information
            // 
            customer_information.BackColor = SystemColors.ButtonHighlight;
            customer_information.BorderStyle = BorderStyle.Fixed3D;
            customer_information.Controls.Add(label1);
            customer_information.Controls.Add(customer_info);
            customer_information.Controls.Add(panel9);
            customer_information.Controls.Add(panel8);
            customer_information.Controls.Add(panel7);
            customer_information.Controls.Add(panel5);
            customer_information.Controls.Add(panel4);
            customer_information.Location = new Point(809, 80);
            customer_information.Margin = new Padding(3, 4, 3, 4);
            customer_information.Name = "customer_information";
            customer_information.Size = new Size(287, 684);
            customer_information.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 355);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 26;
            label1.Text = "상담이력";
            // 
            // customer_info
            // 
            customer_info.AutoSize = true;
            customer_info.BackColor = SystemColors.Window;
            customer_info.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customer_info.Location = new Point(19, 15);
            customer_info.Name = "customer_info";
            customer_info.Size = new Size(110, 32);
            customer_info.TabIndex = 25;
            customer_info.Text = "고객정보";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.InactiveCaption;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(7, 410);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(272, 263);
            panel9.TabIndex = 23;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.InactiveCaption;
            panel8.Controls.Add(listView1);
            panel8.Location = new Point(7, 68);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(272, 259);
            panel8.TabIndex = 22;
            panel8.Paint += panel8_Paint;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(266, 253);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDarkDark;
            panel7.Location = new Point(8, 332);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(272, 2);
            panel7.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Location = new Point(141, 342);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 62);
            panel5.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(button1);
            panel4.Location = new Point(140, -2);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 62);
            panel4.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(3, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 66);
            button1.TabIndex = 22;
            button1.Text = "서버시작";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(chatterbox);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 684);
            panel2.TabIndex = 18;
            // 
            // chatterbox
            // 
            chatterbox.AutoSize = true;
            chatterbox.BackColor = SystemColors.Window;
            chatterbox.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chatterbox.Location = new Point(20, 15);
            chatterbox.Name = "chatterbox";
            chatterbox.Size = new Size(110, 32);
            chatterbox.TabIndex = 22;
            chatterbox.Text = "채팅상담";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLight;
            panel6.Location = new Point(140, -2);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(144, 62);
            panel6.TabIndex = 24;
            // 
            // imgSend
            // 
            imgSend.BackColor = SystemColors.Window;
            imgSend.BackgroundImage = Properties.Resources.사진보내기_버튼;
            imgSend.BackgroundImageLayout = ImageLayout.Zoom;
            imgSend.FlatStyle = FlatStyle.Popup;
            imgSend.Location = new Point(286, 709);
            imgSend.Margin = new Padding(3, 4, 3, 4);
            imgSend.Name = "imgSend";
            imgSend.Size = new Size(53, 55);
            imgSend.TabIndex = 21;
            imgSend.UseVisualStyleBackColor = false;
            // 
            // msgSend
            // 
            msgSend.BackColor = SystemColors.ControlLightLight;
            msgSend.BackgroundImage = Properties.Resources.보내기_버튼;
            msgSend.BackgroundImageLayout = ImageLayout.Zoom;
            msgSend.FlatStyle = FlatStyle.Flat;
            msgSend.Location = new Point(756, 709);
            msgSend.Margin = new Padding(3, 4, 3, 4);
            msgSend.Name = "msgSend";
            msgSend.Size = new Size(56, 55);
            msgSend.TabIndex = 20;
            msgSend.UseVisualStyleBackColor = false;
            msgSend.Click += msgSend_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 709);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 54);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlText;
            panel3.Location = new Point(338, 710);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 1);
            panel3.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(291, 80);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(516, 622);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // serverform_chatting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1097, 831);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Controls.Add(imgSend);
            Controls.Add(msgSend);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(customer_information);
            Controls.Add(Below_bar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "serverform_chatting";
            Text = "serverform_chatting";
            Load += serverform_chatting_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Below_bar.ResumeLayout(false);
            Below_bar.PerformLayout();
            customer_information.ResumeLayout(false);
            customer_information.PerformLayout();
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button sv_search;
        private Button menu;
        private Button search;
        private Label CSmain;
        private Panel Below_bar;
        private Label CStime_msg;
        private Label CStime;
        private Panel customer_information;
        private Panel panel2;
        private Button imgSend;
        private Button msgSend;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label chatterbox;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label customer_info;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private ListView listView1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}