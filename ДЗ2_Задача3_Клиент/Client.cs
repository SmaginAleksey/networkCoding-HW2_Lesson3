using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗ2_Задача3_Клиент
{
    public partial class Client : Form
    {
        private Socket socket;
        private byte[] buffer;
        private IPEndPoint endPoint;
        public Client()
        {
            InitializeComponent();
        }

        private void radioButtonAI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAI.Checked)
            {
                buttonSend.Enabled = false;
            }
            else
            {
                buttonSend.Enabled = true;
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            buffer = new byte[1024];
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            endPoint = new IPEndPoint(IPAddress.Any, 1024);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            try
            {
                socket.Connect(endPoint);
                textBoxMain.Text += $"\nПодключено к {endPoint.Address}";
                buttonStart.Enabled = false;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SendMessage(string msg)
        {
            try
            {
                if (socket.Connected)
                {
                    socket.Send(Encoding.Unicode.GetBytes(msg));
                    byte[] buffer = new byte[1024];
                    int l = socket.Receive(buffer);
                    textBoxMain.Text += Encoding.Unicode.GetString(buffer, 0, l);
                }
                else
                    MessageBox.Show("Error");
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            if (socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}