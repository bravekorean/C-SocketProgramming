using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCPpj_main
{
    public partial class ClientWin : Form
    {
        TcpClient client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;
        Thread ReceiveThread;
        bool Connected;

        private delegate void AddTextDelegate(string strText);

        public ClientWin()
        {
            InitializeComponent();
        }

        private void ClientWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (client != null) client.Close();
            if (ReceiveThread != null) ReceiveThread.Abort();
        }

        private void ClientWin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse("127.0.0.1"), 9000);

                stream = client.GetStream();
                Connected = true;
                richTextBox1.AppendText("Connected to Server!" + "\r\n");

                Reader = new StreamReader(stream);
                Writer = new StreamWriter(stream);

                // 로그인 타입 전송
                Writer.WriteLine("유저");
                Writer.Flush();

                ReceiveThread = new Thread(new ThreadStart(Receive));
                ReceiveThread.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("연결 실패");
            }
        }

        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(UpdateRichTextBox);

            while (Connected)
            {
                Thread.Sleep(1);

                if (stream.CanRead)
                {
                    string tempStr = Reader.ReadLine();

                    if (tempStr != null && tempStr.Length > 0)
                    {
                        Invoke(AddText, "<- Server: " + tempStr + "\r\n");
                    }
                }
            }
        }

        private void UpdateRichTextBox(string text)
        {
            richTextBox1.AppendText(text);
        }

        private void msgSend_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            richTextBox1.AppendText("Me: " + textBox1.Text + "\r\n");
            Writer.WriteLine(textBox1.Text);
            Writer.Flush();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
