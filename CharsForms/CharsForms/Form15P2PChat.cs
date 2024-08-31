using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CharsForms
{
    public partial class Form15P2PChat : Form
    {
        public Form15P2PChat()
        {
            InitializeComponent();
        }
        private Thread thread;
        private TcpListener tcpListener;
        private static string message = "";

        private void clearBtn_Click(object sender, EventArgs e)
        {
            rtbContent.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            IPAddress[] iPAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            //string strMsg = " " + nameTb.Text + "(" + hostTb.Text + ")" + DateTime.Now.ToLongTimeString() + "\n" + " " + this.rtbSend.Text + "\n";
            string strMsg = " " + nameTb.Text + "(" + iPAddresses[0].ToString() + ")" + DateTime.Now.ToLongTimeString() + "\n" + " " + this.rtbSend.Text + "\n";
            TcpClient tcpClient = new TcpClient(nameTb.Text, 100);
            NetworkStream stream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(stream, Encoding.Default);
            streamWriter.Write(strMsg);
            streamWriter.Flush();
            streamWriter.Close();
            tcpClient.Close();
            rtbContent.AppendText(message);
            rtbContent.ScrollToCaret();
            rtbSend.Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form15P2PChat_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(this.StartListener));
            thread.Start();
            timer1.Start();
        }

        private void StartListener()
        {
            message = "";
            tcpListener = new TcpListener(100);
            tcpListener.Start();
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                NetworkStream networkStream = tcpClient.GetStream();
                byte[] buffer = new byte[1024];
                int i = networkStream.Read(buffer, 0, buffer.Length);
                message = Encoding.Default.GetString(buffer, 0, i);
            }
        }

        private void Form15P2PChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(tcpListener != null)
               tcpListener.Stop();

            if(thread != null)
                if(thread.ThreadState == ThreadState.Running)
                    thread.Interrupt();
        }
    }
}
