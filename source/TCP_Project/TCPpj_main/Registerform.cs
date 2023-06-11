using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace TCPpj_main
{
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();

        }

        private void Re_text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Re_text2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Registerbutton_Click(object sender, EventArgs e)
        {

            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\C++git\\source\\db\\memberDB.db; Version = 3;");
                connection.Open();
                string idValue = Re_text1.Text;
                string typeValue = (idValue == "admin" || idValue == "admin1" || idValue == "admin2") ? "admin" : "user";
                string insertQuery = "INSERT INTO memberTbl (id, type, password) VALUES ('" + idValue + "', '" + typeValue + "', '" + Re_text2.Text + "');";
                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(Re_text1.Text + "님 회원가입 완료");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
    }
}


