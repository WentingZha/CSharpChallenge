using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{
    public partial class Form14Network : Form
    {
        public Form14Network()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (hostAddrTb.Text == string.Empty)
            {
                MessageBox.Show("Please enter the Host Address!");
            }
            else
            {
                ipAddrTb.Text = string.Empty;
                IPAddress[] ips = Dns.GetHostAddresses(hostAddrTb.Text);
                foreach (IPAddress ip in ips)
                {
                    ipAddrTb.Text += ip.ToString();
                    ipAddrInfoLabel.Text = "Internet IP: " + ip.Address + "\nIp family: " + ip.AddressFamily.ToString()
                        + "\nIs IpV6 Link Local: " + ip.IsIPv6LinkLocal;
                }
                localNameTb.Text = Dns.GetHostName();
                //dnsNameTb.Text = Dns.GetHostByName(Dns.GetHostName()).HostName;

                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(hostAddrTb.Text), 80);
                ipEndPointLabel.Text += "IP Address: " + iPEndPoint.Address.ToString() + "\nPost: " + iPEndPoint.Port;

            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            downloadRichTextBox.Text = string.Empty;
            WebClient webClient = new WebClient();
            webClient.BaseAddress = downloadTb.Text;
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            Stream stream = webClient.OpenRead(downloadTb.Text);
            StreamReader streamReader = new StreamReader(stream);
            string str = string.Empty;
            while ((str = streamReader.ReadLine()) != null)
            {
                downloadRichTextBox.Text += str + "\n";
            }
            webClient.DownloadFile(downloadTb.Text, DateTime.Now.ToFileTime() + ".txt");
            MessageBox.Show("File Saved");
        }

        private void sendRequstBtn_Click(object sender, EventArgs e)
        {
            requestRichTb.Text = string.Empty;
            WebRequest webRequest = WebRequest.Create(requestTb.Text);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            requestRichTb.Text = "Request Content length: " + webRequest.ContentLength;
            requestRichTb.Text += "\nRequest Method: " + webRequest.Method;
            requestRichTb.Text += "\nRequest Proxy: " + webRequest.Proxy;
            requestRichTb.Text += "\nRequest Internet URI: " + webRequest.RequestUri;
            requestRichTb.Text += "\nRequest Timeout: " + webRequest.Timeout;
            WebResponse webResponse = webRequest.GetResponse();
            requestRichTb.Text += "\nResponse URI: " + webResponse.ResponseUri;
            Stream stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            requestRichTb.Text += streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            webResponse.Close();
        }

        private void tcpBtn_Click(object sender, EventArgs e)
        {
            tcpRichTb.Text = "Waiting for connection....";
            TcpListener tcpListener = null;
            IPAddress iPAddress = IPAddress.Parse(tcpIPTb.Text);
            int port = Convert.ToInt32(tcpPortTb.Text);
            tcpListener = new TcpListener(iPAddress, port);
            tcpListener.Start();
            TcpClient tcpClient = null;
            if (tcpListener.Pending())
                tcpClient = tcpListener.AcceptTcpClient();
            else
                tcpClient = new TcpClient(tcpIPTb.Text, port);
            tcpRichTb.Text += "\nConnected!";
            tcpClient.Close();
            tcpListener.Stop();

        }

        private void udpBtn_Click(object sender, EventArgs e)
        {
            tcpRichTb.Text = "Waiting for connection....";
            UdpClient udpClient = new UdpClient(Convert.ToInt32(tcpPortTb.Text));
            udpClient.Connect(tcpIPTb.Text, Convert.ToInt32(tcpPortTb.Text));
            Byte[] sendBytes = Encoding.Default.GetBytes(udpTb.Text);
            udpClient.Send(sendBytes, sendBytes.Length);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Byte[] receiveBytes = udpClient.Receive(ref iPEndPoint);
            string returnData = Encoding.Default.GetString(receiveBytes);
            tcpRichTb.Text += "\nReceived message: " + returnData.ToString();
            tcpRichTb.Text += "\nMessage comes from host: " + iPEndPoint.Address.ToString()
                + "\nPort is " + iPEndPoint.Port.ToString();
            udpClient.Close();

        }

    }
}
