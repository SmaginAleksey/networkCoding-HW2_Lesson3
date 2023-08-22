using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗ2_Задача3_Сервер
{
    public partial class Server : Form
    {
        private Socket serverSocket;
        private byte[] buffer;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            buffer = new byte[1024];
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 1024));
            serverSocket.Listen(10);

            textBoxMain.Text += $"[{DateTime.Now.ToShortTimeString()}] Сервер запущен. Ожидаются подключения...";

            Thread acceptThread = new Thread(AcceptClient);
            acceptThread.Start();
        }
        private void AcceptClient()
        {
            Socket clientSocket = null;
            try
            {
                while (true)
                {
                    clientSocket = serverSocket.Accept();
                    textBoxMain.Text += $"\r\n[{DateTime.Now.ToShortTimeString()}] подключен {clientSocket.RemoteEndPoint}";
                    Thread receiveThread = new Thread(() => ReceiveData(clientSocket));
                    receiveThread.Start();
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (clientSocket != null && clientSocket.Connected)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
        }
        private void ReceiveData(Socket clientSocket)
        {
            while (true)
            {
                int bytesRead = clientSocket.Receive(buffer);
                string receivedData = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                textBoxMain.Text += $"\r\n[{DateTime.Now.ToShortTimeString()}] от " +
                        $"{((IPEndPoint)clientSocket.RemoteEndPoint).Address} получена строка: \"{receivedData}\"";

                if (receivedData.ToLower() == "date")
                {
                    clientSocket.Send(Encoding.Unicode.GetBytes($"\r\nСегодня {DateTime.Now.ToShortDateString()}"));
                }
                else if (receivedData.ToLower() == "time")
                {
                    clientSocket.Send(Encoding.Unicode.GetBytes($"\r\nТекущее время на сервере - " +
                        $"{DateTime.Now.ToLongTimeString()} GMT +7"));
                }
                else
                {
                    clientSocket.Send(Encoding.Unicode.GetBytes($"\r\nВаш запрос \"{receivedData}\" не распознан. Введите корректный запрос."));
                }
            }
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
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverSocket.Connected)
            {
                serverSocket.Shutdown(SocketShutdown.Both);
                serverSocket.Close();
            }
        }
    }
}
