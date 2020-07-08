using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ArduinoAdapter
{
    public partial class Form1 : Form
    {
        private TcpListener tcpServer = null;
        private Thread tcpServerThread;

        public Form1()
       { 
            InitializeComponent();
        }

        private void threadFunction()
        {
            
        }

        private void btn_doConnect_Click(object sender, EventArgs e)
        {
            try
            {
                arduinoSerialInterface.PortName = txt_PortNumber.Text;
                arduinoSerialInterface.Open();
                if (arduinoSerialInterface.IsOpen)
                {
                    btn_doConnect.Enabled = false;
                    btn_doDisconnect.Enabled = true;
                    txt_log.AppendText("Подключение к " + txt_PortNumber.Text + " выполнено успешно!" + Environment.NewLine);

                    if (tcpServer == null)
                    {
                        tcpServer = new TcpListener(IPAddress.Any, 8080);
                        tcpServer.Start();
                        while (true)
                        {
                            Console.WriteLine("Ожидание подключений...");
                            TcpClient client = tcpServer.AcceptTcpClient();
                            NetworkStream stream = client.GetStream();
                            string response = "Соединение установлено";
                            byte[] data = Encoding.UTF8.GetBytes(response);

                            stream.Write(data, 0, data.Length);
                            Console.WriteLine("Сообщение" + response + "отправлено");
                            stream.Close();
                            client.Close();
                        }
                        tcpServerThread = new Thread(threadFunction);
                        tcpServerThread.Start();
                        txt_log.AppendText("TCP сервер на порту 8080 открыт!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть соединение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (!arduinoSerialInterface.IsOpen)
                {
                    throw new Exception("Serial интерфейс должен быть открыт!");
                }

                arduinoSerialInterface.WriteLine(txt_command.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отправить сообщение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_log.Clear();
        }

        private void tmr_arduino_reader_Tick(object sender, EventArgs e)
        {
            try
            {
                if (arduinoSerialInterface.IsOpen)
                {
                    string data = arduinoSerialInterface.ReadExisting();
                    if (!String.IsNullOrWhiteSpace(data))
                    {
                        string oldValue = txt_log.Text;
                        txt_log.Clear();
                        txt_log.Text = data + Environment.NewLine + oldValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть соединение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_doDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (arduinoSerialInterface.IsOpen)
                {
                    arduinoSerialInterface.Close();
                    btn_doConnect.Enabled = true;
                    btn_doDisconnect.Enabled = false;
                    txt_log.AppendText("Отключение от " + arduinoSerialInterface.PortName + " выполнено успешно!" + Environment.NewLine);
                    tcpServer.Stop();
                    txt_log.AppendText("TCP сервер на порту 8080 закрыт!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось закрыть соединение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (tcpServer != null)
                {
                    tcpServer.Stop();
                }
            }
        }
    }
}
