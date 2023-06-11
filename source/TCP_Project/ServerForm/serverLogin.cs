using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForm
{
    public partial class serverLogin : Form
    {
        public serverLogin()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\C++git\\source\\db\\memberDB.db; Version = 3;");
                connection.Open();


                int login_status = 0;
                // 로그인 상태 변수 선언, 비로그인 상태 0
                string loginid = input_ID.Text;
                // 로그인창에서 아이디 텍스트박스 값
                long loginpwd = long.Parse(input_pass.Text);
                // 로그인창에서 비밀번호 텍스트박스의 값
                string selectQuery = "SELECT * FROM memberTbl WHERE id = \'" + loginid + "\' ";
                // sql에 로그인 아이디가 전송되서 셀렉트문 실행 (user_info 테이블에서 아이디를 기준으로 검색하는것.)

                SQLiteCommand Selectcommand = new SQLiteCommand(selectQuery, connection);
                // mysql로 명령어를 전송하기위한 클래스 mysql에 selectquery의 쿼리문을 보내고 connection 값을 보내 연결시도
                SQLiteDataReader userAccount = Selectcommand.ExecuteReader();
                // 입력값을 받고, ExecuteReader()로 입력값을 받고 해당 정보를 userAccount 변수에 저장함.
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (long)userAccount["password"])
                    {
                        if ((string)userAccount["type"] == "admin")
                        {
                            // 상담사폼 실행
                            serverform_chatting chat = new serverform_chatting();
                            chat.Tag = this;
                            chat.Show();
                            this.Hide();
                            login_status = 1;
                            // 서버 폼 실행
                            //Server server = new Server();
                            //server.ShowDialog();

                        }
                        else
                        {

                            serverLogin main = new serverLogin();
                            main.Tag = this;
                            main.Show();
                            this.Hide();
                            login_status = 0;
                        }

                        // login_status = 1;
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");
                }
                else
                {
                    MessageBox.Show("회원 정보를 확인하시거나 관리자에게 문의 하십시오.");
                }
            }
            // userAccount의 정보를 읽을 동안 로그인 아이디 패스워드가 userAccount에 있는 값과 동일하다면 로그인 상태로 전환(status 1로 변경)
            // 밑에는 로그인상태라면 메세지박스로 로그인완료 메세지 출력 아니라면 회원 정보 재검토 사용자에게 출력 
            // db에서 타입들고와서 type이 admin이면 상담사폼 실행 아닐경우엔 상담자 폼으로 진행 (메인폼으로 리턴)
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void input_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverLogin_Load(object sender, EventArgs e)
        {

        }
    }
}