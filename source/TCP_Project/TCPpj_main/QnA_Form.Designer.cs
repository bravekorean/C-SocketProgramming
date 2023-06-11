namespace TCPpj_main
{
    partial class QnA_Form
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
            shipment_Q = new Button();
            Hi_QnA = new Label();
            panel2 = new Panel();
            shipment_A = new Label();
            take_back_Q = new Button();
            take_back_A = new Label();
            AS_Q = new Button();
            AS_A = new Label();
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
            menu.BackColor = SystemColors.Window;
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
            // shipment_Q
            // 
            shipment_Q.BackgroundImageLayout = ImageLayout.None;
            shipment_Q.FlatStyle = FlatStyle.Flat;
            shipment_Q.Font = new Font("세방고딕 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            shipment_Q.Location = new Point(11, 164);
            shipment_Q.Name = "shipment_Q";
            shipment_Q.Size = new Size(934, 51);
            shipment_Q.TabIndex = 8;
            shipment_Q.Text = "Q. 배송 얼마나 걸리나요?";
            shipment_Q.TextAlign = ContentAlignment.MiddleLeft;
            shipment_Q.UseVisualStyleBackColor = true;
            shipment_Q.Click += shipment_Q_Click;
            // 
            // Hi_QnA
            // 
            Hi_QnA.AutoSize = true;
            Hi_QnA.Font = new Font("세방고딕 Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Hi_QnA.Location = new Point(12, 115);
            Hi_QnA.Name = "Hi_QnA";
            Hi_QnA.Size = new Size(150, 28);
            Hi_QnA.TabIndex = 9;
            Hi_QnA.Text = "자주 묻는 질문";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaptionText;
            panel2.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(12, 146);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 3);
            panel2.TabIndex = 10;
            // 
            // shipment_A
            // 
            shipment_A.AutoSize = true;
            shipment_A.Font = new Font("세방고딕 OTF Regular", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            shipment_A.Location = new Point(12, 228);
            shipment_A.Name = "shipment_A";
            shipment_A.Size = new Size(458, 21);
            shipment_A.TabIndex = 11;
            shipment_A.Text = "A. 주문일로부터 당일출고 및 다음날 오전 출고 어쩌구 저쩌구...";
            // 
            // take_back_Q
            // 
            take_back_Q.BackgroundImageLayout = ImageLayout.None;
            take_back_Q.FlatStyle = FlatStyle.Flat;
            take_back_Q.Font = new Font("세방고딕 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            take_back_Q.Location = new Point(12, 311);
            take_back_Q.Name = "take_back_Q";
            take_back_Q.Size = new Size(934, 51);
            take_back_Q.TabIndex = 12;
            take_back_Q.Text = "Q. 반품/교환해주세요.";
            take_back_Q.TextAlign = ContentAlignment.MiddleLeft;
            take_back_Q.UseVisualStyleBackColor = true;
            take_back_Q.Click += take_back_Q_Click;
            // 
            // take_back_A
            // 
            take_back_A.AutoSize = true;
            take_back_A.Font = new Font("세방고딕 OTF Regular", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            take_back_A.Location = new Point(12, 377);
            take_back_A.Name = "take_back_A";
            take_back_A.Size = new Size(553, 21);
            take_back_A.TabIndex = 13;
            take_back_A.Text = "A. 단순변심 및 고객님의 사이즈 실수로 인한 반품 및 교환은 어쩌구 저쩌구...";
            // 
            // AS_Q
            // 
            AS_Q.BackgroundImageLayout = ImageLayout.None;
            AS_Q.FlatStyle = FlatStyle.Flat;
            AS_Q.Font = new Font("세방고딕 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            AS_Q.Location = new Point(12, 458);
            AS_Q.Name = "AS_Q";
            AS_Q.Size = new Size(934, 51);
            AS_Q.TabIndex = 14;
            AS_Q.Text = "Q. A/S 기간은 언제까지인가요?";
            AS_Q.TextAlign = ContentAlignment.MiddleLeft;
            AS_Q.UseVisualStyleBackColor = true;
            AS_Q.Click += AS_Q_Click;
            // 
            // AS_A
            // 
            AS_A.AutoSize = true;
            AS_A.Font = new Font("세방고딕 OTF Regular", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            AS_A.Location = new Point(11, 522);
            AS_A.Name = "AS_A";
            AS_A.Size = new Size(945, 21);
            AS_A.TabIndex = 15;
            AS_A.Text = "A. 구매일로부터 1년입니다. A/S 처리 시 구매내역 확인이 필요하며 구매내역 증빙이 없을 시 A/S 처리의 제약이 있을 수 있습니다.";
            // 
            // QnA_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(987, 665);
            Controls.Add(AS_A);
            Controls.Add(AS_Q);
            Controls.Add(take_back_A);
            Controls.Add(take_back_Q);
            Controls.Add(shipment_A);
            Controls.Add(panel2);
            Controls.Add(Hi_QnA);
            Controls.Add(shipment_Q);
            Controls.Add(Below_bar);
            Controls.Add(panel1);
            Name = "QnA_Form";
            Text = "QnA";
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
        private Button shipment_Q;
        private Label Hi_QnA;
        private Panel panel2;
        private Label shipment_A;
        private Button take_back_Q;
        private Label take_back_A;
        private Button AS_Q;
        private Label AS_A;
    }
}