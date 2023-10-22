using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace client // клиент
{
    public partial class Form1 : Form
    {
        private int remotePort = 0;
        private const string ip = "127.0.0.1";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (remotePort != 0)
            {
                Socket _socketUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), remotePort);
                byte[] data = Encoding.UTF8.GetBytes(textMessage.Text);
                _socketUdp.SendTo(data, remoteEndPoint);
                _socketUdp.Close();
            }
            else MessageBox.Show("неверный порт");
        }

        private void RemotePortTextBox_TextChanged(object sender, EventArgs e)
        {
            remotePort = int.Parse(RemotePortTextBox.Text);
        }
    }
}