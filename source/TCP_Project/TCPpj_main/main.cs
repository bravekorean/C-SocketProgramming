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
        private void QnA_Click(object sender, EventArgs e)  //����ȭ�� QnA��ư
        {
            //QnA ������ �Ѿ
            QnA_Form qna = new QnA_Form();
            qna.Tag = this;
            qna.Show();
            this.Hide();
        }

        private void CSR_Click(object sender, EventArgs e)  //����ȭ�� ���翬�� ��ư
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
                MessageBox.Show("�α������ּ���.");
            }
            
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //�α��� ��ũ
        {
            //�α���ȭ������ �Ѿ�� �����Ѱ�
            login f2 = new login();
            f2.Tag = this;
            f2.Show();
            this.Hide();

            // �α������� �޾ƿͼ� �α��� ������ 1 �̶�� ��� �г������� �ٲ۴�. if ()
        }

        private void login_msg2_Click(object sender, EventArgs e)
        {

        }
    }
}