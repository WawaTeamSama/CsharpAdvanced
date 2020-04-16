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

                    ShowMessage(socketSend.RemoteEndPoint.ToString()+":连接成功！"):
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

        }
        private void ShowMessage(string msgStr)
        {
            txtLog.AppendText(msgStr + "\r\n");
        }
        #endregion
    }
}
