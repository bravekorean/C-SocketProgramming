using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPpj_main;

namespace TCPpj_main
{

    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        public static class LoginManager
        {
            public static int login_status = 0;
        }
        private void search_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        private void joinlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { // 회원가입 폼 실행
            Registerform rsf = new Registerform();
            rsf.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\C++git\\source\\db\\memberDB.db; Version = 3;");
                connection.Open();

                //int login_status = 0;
                string loginid = input_ID.Text;
                long loginpwd = long.Parse(input_pass.Text);
                string selectQuery = "SELECT * FROM memberTbl WHERE id = \'" + loginid + "\' ";

                SQLiteCommand Selectcommand = new SQLiteCommand(selectQuery, connection);
                SQLiteDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {

                    if (loginid == (string)userAccount["id"] && loginpwd == (long)userAccount["password"])
                    {

                        LoginManager.login_status = 1;

                        if ((string)userAccount["type"] == "admin")
                        {
                            // 서버로 로그인 정보 전송
                            TcpClient client = new TcpClient("127.0.0.1", 9000);
                            
                            NetworkStream stream = client.GetStream();
                            // StreamWriter writer = new StreamWriter(stream);

                            using (StreamWriter writer = new StreamWriter(stream))
                            { // 로그인 ID와 유형을 스트림에 작성
                                writer.WriteLine(loginid); // 로그인 ID 작성
                                writer.WriteLine("admin"); // 유형을 "admin"으로 작성
                                writer.Flush(); // 작성한 데이터를 전송하기 위해 버퍼 비우기

                                writer.Close();
                                stream.Close();
                                client.Close();
                            }
                            if (LoginManager.login_status == 1)
                            {
                                MessageBox.Show("로그인 완료");
                            }
                            else
                            {
                                MessageBox.Show("회원 정보를 확인해 주세요.");
                            }
                            // 서버 폼 열기
                            // serverform_chatting serverForm = new serverform_chatting();
                            //serverForm.ShowDialog();
                        }
                        else
                        {
                            // 서버로 로그인 정보 전송
                            TcpClient client = new TcpClient("127.0.0.1", 9000);
                            NetworkStream stream = client.GetStream();
                            //StreamWriter writer = new StreamWriter(stream);

                            using (StreamWriter writer = new StreamWriter(stream))
                            { 
                                // 로그인 ID와 유형을 스트림에 작성
                                writer.WriteLine(loginid); // 로그인 ID 작성
                                writer.WriteLine("user"); // 유형을 "admin"으로 작성
                                writer.Flush(); // 작성한 데이터를 전송하기 위해 버퍼 비우기

                                writer.Close();
                                stream.Close();
                                client.Close();
                            }
                            if (LoginManager.login_status == 1)
                            {
                                MessageBox.Show("로그인 완료");
                            }
                            else
                            {
                                MessageBox.Show("회원 정보를 확인해 주세요.");
                            }
                            main main = new main();
                            main.Tag = this;
                            main.Show();
                            this.Hide();
                        }

                        
                    }
                }
                connection.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void input_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
