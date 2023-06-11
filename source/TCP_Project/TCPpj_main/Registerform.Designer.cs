namespace TCPpj_main
{
    partial class Registerform
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
            id_text = new Label();
            pw_text = new Label();
            Re_text1 = new TextBox();
            Re_text2 = new TextBox();
            Registerbutton = new Button();
            SuspendLayout();
            // 
            // id_text
            // 
            id_text.AutoSize = true;
            id_text.Location = new Point(204, 106);
            id_text.Name = "id_text";
            id_text.Size = new Size(54, 20);
            id_text.TabIndex = 0;
            id_text.Text = "아이디";
            // 
            // pw_text
            // 
            pw_text.AutoSize = true;
            pw_text.Location = new Point(204, 144);
            pw_text.Name = "pw_text";
            pw_text.Size = new Size(69, 20);
            pw_text.TabIndex = 1;
            pw_text.Text = "비밀번호";
            // 
            // Re_text1
            // 
            Re_text1.Location = new Point(309, 106);
            Re_text1.Name = "Re_text1";
            Re_text1.Size = new Size(125, 27);
            Re_text1.TabIndex = 3;
            Re_text1.TextChanged += Re_text1_TextChanged;
            // 
            // Re_text2
            // 
            Re_text2.Location = new Point(309, 144);
            Re_text2.Name = "Re_text2";
            Re_text2.Size = new Size(125, 27);
            Re_text2.TabIndex = 4;
            Re_text2.TextChanged += Re_text2_TextChanged;
            // 
            // Registerbutton
            // 
            Registerbutton.Location = new Point(451, 106);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(94, 65);
            Registerbutton.TabIndex = 6;
            Registerbutton.Text = "회원가입";
            Registerbutton.UseVisualStyleBackColor = true;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // Registerform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Registerbutton);
            Controls.Add(Re_text2);
            Controls.Add(Re_text1);
            Controls.Add(pw_text);
            Controls.Add(id_text);
            Name = "Registerform";
            Text = "Registerform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label id_text;
        private Label pw_text;
        private TextBox Re_text1;
        private TextBox Re_text2;
        private Button Registerbutton;
    }
}