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
        //private const string ip = "127.0.0.1";
        private Thread _thread;
        private IPEndPoint _endPoint;
        private UdpClient udpClient;

        public Form1()
        {
            InitializeComponent();
        }


        private void inputButton_Click(object sender, EventArgs e)
        {
            if (localPort != 0)
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
                try
                {
                    _endPoint = new IPEndPoint(IPAddress.Any, localPort);
                    data = udpClient.Receive(ref _endPoint);
                }
                catch
                {
                    MessageBox.Show(@"ошибка на стадии _endpoint и byte");
                    
                }
                richTextBox1.AppendText(Encoding.UTF8.GetString(data ?? throw new InvalidOperationException()));
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (udpClient!=null) udpClient.Close();
            _thread.Join();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemotePortTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LocalPortTextBox_TextChanged(object sender, EventArgs e)
        {
            localPort = int.Parse(LocalPortTextBox.Text);
        }
        
    }
}