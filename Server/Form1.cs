using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取本机的IP
            var hostName = Dns.GetHostName();
            var localhostiPs = Dns.GetHostByName(hostName);
            IPAddress IP = localhostiPs.AddressList[0];
            txtServer.Text = IP.ToString();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        #region 监听方法
        private Socket socketSend;
        private Dictionary<string, Socket> distanceSocket = new Dictionary<string, Socket>();
        private void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                //监听
                try 
                {
                    //负责和客户端通信
                    socketSend = socketWatch.Accept();
                    //将远程连接的客户端的IP地址和Socket存入集合中
                    distanceSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);

                    //将远程连接客户端的IP加入下拉框
                    cbUser.Items.Add(socketSend.RemoteEndPoint .ToString());

                    ShowMessage(socketSend.RemoteEndPoint.ToString() + ":连接成功！");
                    //开新的线程 不停地接收客户端发送的请求
                    Thread th = new Thread(Receive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                {
                    MessageBox.Show("网络连接错误，请重新连入");
                }

            }
        }
        /// <summary>
        /// 服务端不停的接受客户端发送来的消息
        /// </summary>
        /// <param name="o"></param>
        private void Receive(object o)
        {
            //转换传入的参数类型
            Socket socketSend = o as Socket;
            //用循环持续接收二进制消息
            while (true)
            {
                //每次读取2M
                byte[] buffer = new byte[1024 * 1024 * 2];
                //实际接收的有效字节数
                int r = socketSend.Receive(buffer);
                //当字节读取完成时 跳出循环
                if (r == 0)
                {
                    break;
                }
                var str = Encoding.UTF8.GetString(buffer, 0, r);
                ShowMessage(socketSend.RemoteEndPoint + ":" + str);
            }
        }
        private void ShowMessage(string msgStr)
        {
            txtLog.AppendText(msgStr + "\r\n");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //当用户点击开始监听时 在服务器端创建一个负责监听的IP地址和端口号
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

                //开始监听
                socketWatch.Bind(point);
                ShowMessage("监听成功！");
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
                    }
            catch
            {
                MessageBox.Show("网络连接错误，请重新连接");
            }
        }
    }
}
