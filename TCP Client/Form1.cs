using System.Net;
using System.Net.Sockets;

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            IPAddress? serverIP;
            int serverPort;
            if(IPAddress.TryParse(ServerIPTextBox.Text, out serverIP) 
                && int.TryParse(ServerPortTextBox.Text,out serverPort) 
                && serverPort > 0)
            {
                try
                {
                    TcpClient tcpClient = new TcpClient(ServerIPTextBox.Text, serverPort);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ClientPrompt.Text += $"Provide valid server address and port first. {Environment.NewLine}";
            }

        }
    }
}