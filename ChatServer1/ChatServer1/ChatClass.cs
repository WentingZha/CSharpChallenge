using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


public class ChatClass
{
	public const int port = 11000;

	public void StartListener()
	{ 
		UdpClient udpClient = new UdpClient(port);	
		IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, port);
		try
		{
			while (true)
			{
				byte[] array = udpClient.Receive(ref remoteEp);
				string caption = "Message is from " + remoteEp.Address.ToString();
				string @string = Encoding.GetEncoding("utf-8").GetString(array, 0, array.Length);
				MessageBox.Show(@string, caption);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
		finally
		{ 
			udpClient.Close();
		}
	}

	public string Send(string strServer, string strContent)
	{
		Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
		IPAddress addr = IPAddress.Parse(strServer);
		//byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(strContent);
		byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(strContent);
		IPEndPoint remoteEndPoint = new IPEndPoint(addr, port);
		socket.SendTo(bytes, remoteEndPoint);
		socket.Close();
		return "Message is sended!";
	}
}
