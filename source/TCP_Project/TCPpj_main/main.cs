using System;

using System.Collections.Generic;

using System.Net;

using System.Net.Sockets;

using System.Text;

using System.Threading;

using System.Windows.Forms;
using TCPpj_main;
using static TCPpj_main.login;

namespace TCPpj_main
{
    public partial class main : Form

    {






        public main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //login f2 = new login();
            //f2.Tag = this;
            //f2.ShowDialog();
            //this.Show();

        }
        private void Form1_Close(object sender, EventArgs e)
        {

        }
        private void QnA_Click(object sender, EventArgs e)  //메인화면 QnA버튼
        {
            //QnA 폼으로 넘어감
            QnA_Form qna = new QnA_Form();
            qna.Tag = this;
            qna.Show();
            this.Hide();
        }

        private void CSR_Click(object sender, EventArgs e)  //메인화면 상담사연결 버튼
        {
            int login_status = LoginManager.login_status;

            if (login_status == 1) { 
            this.Hide();
            ClientWin ld = new ClientWin();
            ld.Tag = this;
            ld.ShowDialog();
            this.Show();
              }
            else
            {
                MessageBox.Show("로그인해주세요.");
            }
            
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //로그인 링크
        {
            //로그인화면으로 넘어가게 설정한거
            login f2 = new login();
            f2.Tag = this;
            f2.Show();
            this.Hide();

            // 로그인정보 받아와서 로그인 정보가 1 이라면 얘는 닉네임으로 바꾼다. if ()
        }

        private void login_msg2_Click(object sender, EventArgs e)
        {

        }
    }
}