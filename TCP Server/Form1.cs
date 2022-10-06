using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        private TcpListener tcpServer = null;
        private CancellationTokenSource cts = null;
        private bool serverActive = false;
        //private Byte[] buffer = new byte[1024];
        private Dictionary<TcpClient,bool> clients = new Dictionary<TcpClient,bool>();
        private List<Task> clientTasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in localIP)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPTextbox.Text = ip.ToString();
                }
            }
        }

        private async Task HandleClientCommunication(TcpClient client)
        {
            while (clients[client] == true)
            {
                // communication with client
                await Task.Delay(1000);
                ServerPrompt.Text += $"communicating with {client.Client.RemoteEndPoint}...{Environment.NewLine}";
            }

            // after receiving order to disconnect close the connection
            ServerPrompt.Text += $"{client.Client.RemoteEndPoint} disconnected.{Environment.NewLine}";
            client.GetStream().Close();
            client.Close(); 
        }

        // main function responsible for hnadling server operation
        private async void StartButton_Click(object sender, EventArgs e)
        {
            int port;
            if(int.TryParse(ServerPortTextBox.Text, out port) && port > 0)
            {
                ServerPrompt.Text += $"Server is satrting...{Environment.NewLine}";

                // starting server
                try 
                {
                    tcpServer = new TcpListener(IPAddress.Any, port);
                    tcpServer.Start();
                    ServerPrompt.Text += $"Server started on port nr {port}{Environment.NewLine}";

                    StartButton.Enabled = false;
                    ServerStopButton.Enabled = true;
                    serverActive = true;

                    // accepting connections
                    while (serverActive)
                    {
                        cts = new CancellationTokenSource();
                        CancellationToken token = cts.Token;
                        // wait for the new client
                        var newConnectionTask = tcpServer.AcceptTcpClientAsync(token);
                        TcpClient newClient = await newConnectionTask;
                        cts.Dispose();
                        // we have new client
                        ClientListBox.Items.Add($"{newClient.Client.RemoteEndPoint as IPEndPoint}");
                        clients.Add(newClient, true);
                        ServerPrompt.Text += $"New Client connected on address: {newClient.Client.RemoteEndPoint as IPEndPoint}{Environment.NewLine}";
                        
                        // handle client assynchronously
                        clientTasks.Add(HandleClientCommunication(newClient));
                    }

                }
                catch(Exception ex)
                {
                    if(!(ex is OperationCanceledException))
                        MessageBox.Show("HANDLER: " + ex.Message.ToString());
                }

            }
            else
            {
                ServerPrompt.Text += $"Please provide a valid port number first.{Environment.NewLine}";
            }

            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        // function responsible for shutting down the server
        private async void ServerStopButton_Click(object sender, EventArgs e)
        {
            if (serverActive)
            {
                try
                {
                    cts.Cancel();
                    // order all clients to become disconnected
                    foreach(var client  in clients.Keys.ToList())
                    {
                        clients[client] = false;
                    }

                    // wait for all clients to end connections
                    foreach(var task in clientTasks)
                    {
                        await task;
                    }


                    // clear lists and shutdown the server
                    clients.Clear();
                    ClientListBox.Items.Clear();
                    tcpServer.Stop();
                    StartButton.Enabled = true;
                    ServerStopButton.Enabled = false;
                    serverActive = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}