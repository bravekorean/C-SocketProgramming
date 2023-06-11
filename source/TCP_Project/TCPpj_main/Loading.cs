using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPpj_main
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void link_QnA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)   //간편해결 바로가기
        {
            //이 기능을 QnA 링크 타게 만들까 하는데 QnA 폼을 안만듬..
        }


        //이거말고 신박한 로딩화면 가능하신 분 찾음..이거 사용방법을 모르겠음..
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        
    }
}
