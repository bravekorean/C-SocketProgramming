using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace ServerForm
{
    public partial class serverform_chatting : Form
    {
        TcpListener Server;
        List<TcpClient> EmptyCList = new List<TcpClient>();  // 빈 클라이언트 리스트
        
        Thread ReceiveThread;
        bool Connected;
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private delegate void AddTextDelegate(string strText);

        [DllImport("Gdi32,dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                    int nLeft,
                    int nTop,
                    int nRight,
                    int nBottom,
                    int nWidthEllipse,
                    int nHeightEllipse
            );

        public serverform_chatting()
        {
            InitializeComponent();
        }

        private void serverform_chatting_Load(object sender, EventArgs e)
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 9000));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }

        private void Listen()
        {
            try
            {
                // 1. chatting room에 text 추가 delegate 함수
                AddTextDelegate AddText = new AddTextDelegate(richTextBox1.AppendText);

                // 2. Server Setting
                serverSocket.Listen(1);
                Invoke(AddText, "Server Start" + "\r\n");

                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    Invoke(AddText, "Connected to Client" + "\r\n");

                    TcpClient client = new TcpClient();
                    client.Client = clientSocket;

                    StreamReader reader = new StreamReader(client.GetStream());
                    string loginType = reader.ReadLine();  // 클라이언트의 로그인 타입 수신

                    if (loginType == "admin")
                    {
                        EmptyCList.Add(client);  // 상담자일 경우 빈 클라이언트 리스트에 추가
                    }
                    else if (loginType == "user" && EmptyCList.Count > 0)
                    {
                        TcpClient counselor = EmptyCList.First();  // 가장 앞에 있는 상담자와 연결
                        EmptyCList.RemoveAt(0);  // 연결된 상담자를 리스트에서 제거

                        StreamWriter writer = new StreamWriter(counselor.GetStream());
                        writer.WriteLine("연결되었습니다.");
                        writer.Flush();

                        writer = new StreamWriter(client.GetStream());
                        writer.WriteLine("연결되었습니다.");
                        writer.Flush();

                        Thread clientThread = new Thread(() => HandleClient(client, counselor));
                        clientThread.Start();
                    }
                    else
                    {
                        StreamWriter writer = new StreamWriter(client.GetStream());
                        writer.WriteLine("상담사가 없습니다. 나중에 다시 시도해주세요.");
                        writer.Flush();

                        client.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("오류");
            }
        }

        private void HandleClient(TcpClient client, TcpClient counselor)
        {
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                string loginType = reader.ReadLine();  // 클라이언트의 로그인 타입 수신

                // SQLite DB에 접근하여 유저 타입에 따른 메시지 설정
                string message;
                if (loginType == "admin")
                {
                    message = "상담사";
                }
                else if (loginType == "user")
                {
                    message = "유저";
                }
                else
                {
                    message = "알 수 없는 유형";
                }

                writer.WriteLine(message);  // 클라이언트에게 메시지 전송
                writer.Flush();

                while (true)
                {
                    string clientMessage = reader.ReadLine();
                    if (clientMessage != null)
                    {
                        // 클라이언트로부터 메시지 수신 후 상담자에게 전송
                        StreamWriter counselorWriter = new StreamWriter(counselor.GetStream());
                        counselorWriter.WriteLine("Client: " + clientMessage);
                        counselorWriter.Flush();
                    }
                }
            }
            catch (Exception)
            {
                counselor.Close();
                client.Close();
            }
        }

        private void msgSend_Click(object sender, EventArgs e)
        {
            // char room에 sender message 추가
            richTextBox1.AppendText("Me: " + textBox1.Text + "\r\n");

            foreach (TcpClient client in EmptyCList)
            {
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.WriteLine(textBox1.Text);
                writer.Flush();
            }

            textBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddChatText(string strText)
        {
            richTextBox1.AppendText(strText);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // panel1_Paint 이벤트 핸들러 내용을 여기에 작성하세요.
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // panel8_Paint 이벤트 핸들러 내용을 여기에 작성하세요.
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DisplayClientList(List<TcpClient> clientList)
        {
            // ListView를 초기화
            listView1.Items.Clear();

            // 클라이언트 리스트를 ListView에 추가
            foreach (TcpClient client in clientList)
            {
                // 클라이언트의 IP 주소와 포트 번호를 가져옴
                string ipAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                int port = ((IPEndPoint)client.Client.RemoteEndPoint).Port;

                // ListView에 항목 추가
                ListViewItem item = new ListViewItem(ipAddress);
                item.SubItems.Add(port.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
