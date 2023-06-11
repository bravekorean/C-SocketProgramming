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
                // �α��� ���� ���� ����, ��α��� ���� 0
                string loginid = input_ID.Text;
                // �α���â���� ���̵� �ؽ�Ʈ�ڽ� ��
                long loginpwd = long.Parse(input_pass.Text);
                // �α���â���� ��й�ȣ �ؽ�Ʈ�ڽ��� ��
                string selectQuery = "SELECT * FROM memberTbl WHERE id = \'" + loginid + "\' ";
                // sql�� �α��� ���̵� ���۵Ǽ� ����Ʈ�� ���� (user_info ���̺��� ���̵� �������� �˻��ϴ°�.)

                SQLiteCommand Selectcommand = new SQLiteCommand(selectQuery, connection);
                // mysql�� ��ɾ �����ϱ����� Ŭ���� mysql�� selectquery�� �������� ������ connection ���� ���� ����õ�
                SQLiteDataReader userAccount = Selectcommand.ExecuteReader();
                // �Է°��� �ް�, ExecuteReader()�� �Է°��� �ް� �ش� ������ userAccount ������ ������.
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (long)userAccount["password"])
                    {
                        if ((string)userAccount["type"] == "admin")
                        {
                            // ������ ����
                            serverform_chatting chat = new serverform_chatting();
                            chat.Tag = this;
                            chat.Show();
                            this.Hide();
                            login_status = 1;
                            // ���� �� ����
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
                    MessageBox.Show("�α��� �Ϸ�");
                }
                else
                {
                    MessageBox.Show("ȸ�� ������ Ȯ���Ͻðų� �����ڿ��� ���� �Ͻʽÿ�.");
                }
            }
            // userAccount�� ������ ���� ���� �α��� ���̵� �н����尡 userAccount�� �ִ� ���� �����ϴٸ� �α��� ���·� ��ȯ(status 1�� ����)
            // �ؿ��� �α��λ��¶�� �޼����ڽ��� �α��οϷ� �޼��� ��� �ƴ϶�� ȸ�� ���� ����� ����ڿ��� ��� 
            // db���� Ÿ�Ե��ͼ� type�� admin�̸� ������ ���� �ƴҰ�쿣 ����� ������ ���� (���������� ����)
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