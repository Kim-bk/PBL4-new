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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL4.cls_module;

namespace PBL4
{
    public partial class Client : Form
    {
        private const int BUFFER_SIZE = 2048; // tương thích với byte[] recv với khoảng 75 số
        cls_Handle handle = new cls_Handle();
        IPEndPoint ipep;
        TcpClient tcpclient;
        Stream stream;
        int stt = 1;
        static int choice;
        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            cbbOptions.Text = "Nhập tay";
            btnChon.Enabled = false;
        }
        public void Reset()
        {
            lblErr.Text = "";
            cbbOptions.Text = "Nhập tay";
            richtxtChat.Text = "";
            txtFile.Text = "";
            txtInput.Text = "";
            txtVietnamese.Text = "";
            txtEnglish.Text = "";
            txtFrench.Text = "";
            txtName.Text = "";
        }

          public void HideFile()
        {
            lblErr.Text = "";
            txtFile.Text = "";
            txtFile.Visible = false;
            btnChon.Visible = false;
            lbFile.Visible = false;
        }
        public void Connect()
        {
            try
            {
                btnChon.Enabled = true;
                ipep = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPort.Text));
                tcpclient = new TcpClient();
                tcpclient.Connect(ipep);
                stream = tcpclient.GetStream();
                btnConnect.Enabled = false;
                Thread recv = new Thread(Receive);
                recv.IsBackground = true;
                recv.Start();

                //gửi name của Client
                string name = "@" + txtName.Text;
                byte[] data = Encoding.UTF8.GetBytes(name);
                stream.Write(data, 0, data.Length);
                AddMessage("Mời bạn nhập vào một số để chương trình tính toán!", "");
            }
            catch(Exception)
            {
                ;
            }
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            stt = 1;
            btnConnect.Enabled = true;
            Reset();
            stream.Close(); 
            tcpclient.Close();
        }

        public void Send()
        {
            if (!btnConnect.Enabled) // đang trong trạng thái Connect
            {
                byte[] data = Encoding.UTF8.GetBytes(txtInput.Text);
                stream.Write(data, 0, data.Length);
                AddMessage(txtInput.Text, "send");
            }
            else
                MessageBox.Show("Vui lòng kết nối đến Server để thực hiện tính toán!");
        }
        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] recv = new byte[BUFFER_SIZE];
                    stream.Read(recv, 0, recv.Length);
                    string s = Encoding.UTF8.GetString(recv);
                    ManageMessage(s);
                }
            }
            catch { }
        }
        public void ManageMessage(string s)
        {
            string[] nums = new string[3];
            int count = 0, startIndex = 0, i = 0, length;
            foreach (char c in s)
            {
                if (c.Equals(','))
                {
                    length = count - startIndex;
                    nums[i] = s.Substring(startIndex, length);
                    i++;
                    startIndex = count + 1;
                }
                if (c.Equals('.'))
                {
                    length = count - startIndex;
                    nums[i] = s.Substring(startIndex, length);
                    break;
                }
                count++;
            }
            txtVietnamese.Text = nums[0];
            txtEnglish.Text = nums[1];
            txtFrench.Text = nums[2];
        }

        public void AddMessage(string s, string options)
        {
            if (options == "send")
            {
                richtxtChat.Text += "\nMe: " + s;
                txtInput.Text = "";
                txtFile.Text = "";
            }
            else
            {
                if (stt == 1)
                    richtxtChat.Text += "Server: " + s;
            }
            stt++;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (choice == 1)
            {
                if (txtInput.Text == "")
                    return; // nếu ô nhập bằng rỗng thì bỏ qua
                else
                {
                    string txt = handle.DeleteDotInNumber(txtInput.Text);
                    if (txt.Length > 75)
                        lblErr.Text = "Không được vượt quá 75 chữ số!"; // giới hạn số nhập vào
                    else
                    {
                        lblErr.Text = "";
                        Send();
                    }
                }
            }
            else if (choice == 0)
            {
                if (txtFile.Text == "")
                {
                    lblErr.Text = "Chưa chọn File!";
                }
                else
                {
                    try
                    {
                        FileStream str = new FileStream(txtFile.Text, FileMode.Open);
                        StreamReader sr = new StreamReader(str);
                        string s = sr.ReadToEnd().ToString();
                        if (s == "" || handle.IsNumeric(s) == false)
                        {
                            lblErr.Text = "Không thể đọc dữ liệu từ File này!";
                            sr.Close();
                        }
                        else
                        {
                            lblErr.Text = "";
                            string tg = handle.FormatNumber(s);
                            byte[] data = Encoding.UTF8.GetBytes(tg);
                            stream.Write(data, 0, data.Length);
                            AddMessage(tg, "send");
                            sr.Close();
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!handle.CheckEmpty(txtPort.Text, txtIP.Text, txtName.Text))
                    Connect();
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối đến Server!");
                Reset();
            }
        }
       
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chặn các ký tự đặc biệt, chỉ được nhập số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // khi nhập số sẽ thêm dấu chấm
            string str = txtInput.Text;
            int start = txtInput.Text.Length - txtInput.SelectionStart;
            str = str.Replace(".", "");
            txtInput.Text = handle.FormatNumber(str);
            txtInput.SelectionStart = -start + txtInput.Text.Length;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txtFile.Text = dlg.FileName;
        }
   
        private void cbbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOptions.SelectedItem.ToString() == "Chọn File")
            {
                lblErr.Text = "";
                txtInput.Text = "";
                txtFile.Visible = true;
                btnChon.Visible = true;
                lbFile.Visible = true;
                txtInput.Visible = false;
                choice = 0;
            }
            else if (cbbOptions.SelectedItem.ToString() == "Nhập tay")
            {
                HideFile();
                txtInput.Visible = true;
                choice = 1;
            }
            else
            {
                HideFile();
                txtInput.Enabled = false;
            }
        }
    }
}
