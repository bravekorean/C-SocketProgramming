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
        TcpClient Client;

        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;

        Thread ReceiveThread;

        bool Connected;
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private delegate void AddTextDelegate(string strText);

        [DllImport("Gdi32,dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }

        private void msgSend_Click(object sender, EventArgs e)
        {
            // chat room에 sender message 추가
            richTextBox1.AppendText("Me: " + textBox1.Text + "\r\n");

            // Client에 chat send
            Writer.WriteLine(textBox1.Text);
            Writer.Flush();

            textBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Listen()
        {
            try
            {
                // 1. chatting room에 text 추가 delegate 함수
                AddTextDelegate AddText = new AddTextDelegate(richTextBox1.AppendText);

                // 2. Server Setting
                Server = new TcpListener(IPAddress.Any, 9000);
                Server.Start();
                Invoke(AddText, "Server Start" + "\r\n");

                // 3. Client Setting
                Client = Server.AcceptTcpClient();
                Connected = true;

                // 4. Stream create
                stream = Client.GetStream();
                Reader = new StreamReader(stream);
                Writer = new StreamWriter(stream);

                // 5. Receive thread start
                ReceiveThread = new Thread(new ThreadStart(Receive));
                ReceiveThread.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("오류");
            }
        }

        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(UpdateChatLog);

            while (Connected)
            {
                // stream에 data 있을 경우
                if (stream.CanRead)
                {
                    string receiveChat = Reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0)
                        Invoke(AddText, "Client: " + receiveChat + "\r\n");
                }
            }
        }

        private void UpdateChatLog(string text)
        {
            richTextBox1.AppendText(text);
        }
    }
}

