using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1  // сервер
{
    public partial class Form1 : Form
    {
        private int localPort = 0;
        private int remotePort = 0;
        private const string ip = "127.0.0.1";
        private Thread _thread;
        private IPEndPoint _endPoint;
        private UdpClient udpClient;

        public Form1()
        {
            InitializeComponent();
        }


        private void inputButton_Click(object sender, EventArgs e)
        {
            if (localPort != 0 && remotePort != 0)
            {
                try
                {
                    udpClient = new UdpClient(localPort);
                    MessageBox.Show("good!");
                    try
                    { 
                        _thread = new Thread(new ThreadStart(Listener));
                        _thread.Start();
                    }
                    catch
                    {
                        MessageBox.Show(@"ошибка создания потока");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"ошибка {ex}");
                }
            }
            else 
                MessageBox.Show("введите порты");
        }

        private void Listener()
        {
            byte[] data = null;
            for (;;)
            { 
                _endPoint = new IPEndPoint(IPAddress.Any, localPort);
                data = udpClient.Receive(ref _endPoint);
                
                richTextBox1.AppendText(Encoding.UTF8.GetString(data ?? throw new InvalidOperationException()));
                richTextBox1.AppendText("\n");
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            udpClient?.Close();
            try
            {
                _thread.Abort();
            }
            catch
            {
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = "user";
        }

        private void RemotePortTextbox_TextChanged(object sender, EventArgs e)
        {
            remotePort = int.Parse(RemotePortTextbox.Text);
        }

        private void LocalPortTextBox_TextChanged(object sender, EventArgs e)
        {
            localPort = int.Parse(LocalPortTextBox.Text);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            UdpClient clientForSend = new UdpClient();
            IPEndPoint endPointForSend = new IPEndPoint(IPAddress.Parse(ip), remotePort);
            byte[] data = Encoding.UTF8.GetBytes($"{NameTextBox.Text}: " + MessageTextBox.Text);
            udpClient.Send(data, data.Length, endPointForSend);
            clientForSend.Close();
            richTextBox1.AppendText($"{NameTextBox.Text}: "+ MessageTextBox.Text);
            MessageTextBox.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient?.Close();
            _thread.Join();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}