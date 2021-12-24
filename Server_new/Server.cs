using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Server;

namespace Server_new
{
    public partial class Server : Form
    {
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public List<Socket> clientSockets = new List<Socket>();
        public List<string> nameClients = new List<string>();
        private byte[] buffer = new byte[2048];
        cls_Format format = new cls_Format();
        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Server_Load(object sender, EventArgs e)
        {
            SetupServer();
        }

        private void SetupServer()
        {
            richtxtChat.Text += "Waitting for connect.....";
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("26.109.234.241"), 6969);
            serverSocket.Bind(ipep);
            serverSocket.Listen(1);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = serverSocket.EndAccept(ar);
            clientSockets.Add(socket);
            txtCount.Text = clientSockets.Count.ToString();
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            string datetime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            Socket current = (Socket)AR.AsyncState;
            if (current.Connected)
            {
                int received;
                try
                {
                    received = current.EndReceive(AR);
                }
                catch (Exception)
                {
                    // client dong ket noi
                    for (int i = 0; i <= clientSockets.Count; i++)
                    {
                        if (clientSockets[i].RemoteEndPoint.ToString().Equals(current.RemoteEndPoint.ToString()))
                        {
                            // xoa khoi list
                            richtxtChat.Text += "\n" + nameClients[i] + " đã ngắt kết nối" + " (" + datetime + ")";
                            clientSockets.RemoveAt(i);
                            nameClients.RemoveAt(i);
                            AddNameClientToBox();
                            break;
                        }
                    }
                    return;
                }

                // nhan duoc du lieu tu client hien thoi
                if (received != 0)
                {
                    byte[] recBuf = new byte[received];
                    Array.Copy(buffer, recBuf, received);
                    string text = Encoding.UTF8.GetString(recBuf);
                    if(!IsName(text)) // kiem tra du lieu nhan co la ten hay khong '@name'
                    {
                        for (int i = 0; i < clientSockets.Count; i++)
                        {
                            // kiem tra dung dia chi RemoteEndPoint cua Client thi gui tra
                            if (current.RemoteEndPoint.ToString().Equals(clientSockets[i].RemoteEndPoint.ToString()))
                            {
                                richtxtChat.Text += "\n"+ nameClients[i] + ": " + text + " (" + datetime + ")";
                                break;
                            }
                        }
                        // gui tra du lieu lai client hien thoi
                        Send(current, format.DeleteDotInNumber(text));
                    }
                    else { 
                        richtxtChat.Text += "\n" + text + " đã kết nối" + " (" + datetime + ")";
                    }
                }
                else
                {
                    for (int i = 0; i < clientSockets.Count; i++)
                    {
                        if (clientSockets[i].RemoteEndPoint.ToString().Equals(current.RemoteEndPoint.ToString()))
                        {
                            richtxtChat.Text += "\n" + nameClients[i] + " đã ngắt kết nối" +" (" + datetime + ")";
                            clientSockets.RemoveAt(i);
                            nameClients.RemoveAt(i);
                            txtCount.Text =  clientSockets.Count.ToString();
                            AddNameClientToBox();
                            break;
                        }
                    }
                }
            }
        
            // bat dau nhan du lieu tu cac Socket da ket noi
            current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), current);
        }
        public void Send(Socket socket, string mess)
        {
            string snumber;
            if(mess=="0")
            {
                string numberInVN = format.NumberToVietnamese(Convert.ToDouble(mess));
                string numberInEng = "Zero";
                string numberInFranc = "Zéro";
                snumber = numberInVN + "," + numberInEng + "," + numberInFranc + ".";
            }
            else
            {
                string numberInVN = format.NumberToVietnamese(Convert.ToDouble(mess));
                string numberInEng = format.NumberToEnglish(mess);
                string numberInFranc = format.NumberToFrench(mess);
                snumber = numberInVN + "," + numberInEng + "," + numberInFranc + "."; 
            }
            var data = Encoding.UTF8.GetBytes(snumber);
            socket.Send(data);
        }

        public bool IsName(string s)
        {
            var arr = s.ToCharArray();
            if (arr[0] == '@')
            {
                nameClients.Add(s);
                AddNameClientToBox();
                return true;
            }
            else return false;
        }
        
        public void AddNameClientToBox()
        {
            richtxtClient.Text = "";
            foreach(string name in nameClients)
            {
                richtxtClient.Text += name + "\n";
            }
        }
    }
}
