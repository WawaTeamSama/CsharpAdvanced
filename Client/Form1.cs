﻿using System;
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
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket socketSend;
        private void btnLink_Click(object sender, EventArgs e)
        {
            try 
            {
                //创建通信对象
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox2.Text));
                //获取连接的远程服务器应用程序的IP地址和端口号
                socketSend.Connect(point);
                ShowMessage("连接" + ip + "：" + textBox2.Text.Trim() + "成功！");

                //开启新线程接受不同服务端发来的消息
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start();
            }
            catch
            {
                MessageBox.Show("连接失败！");
            }
        }
        private void ShowMessage(string msgStr)
        {
            txtLog.AppendText(msgStr + "\r\n");
        }
        private void Receive()
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (socketSend == null || !socketSend.Connected)
            {
                MessageBox.Show("网络连接错误，请重新输入！");
                return;
            }
            try
            {
                var str = textBox3.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                socketSend.Send(buffer);
                textBox3.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("网络连接错误");
            }
        }
    }
}
