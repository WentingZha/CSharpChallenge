// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Runtime.CompilerServices;
using System.Net.Sockets;
using System.Text;

IPAddress ip = IPAddress.Parse("127.0.0.1");
int port = 100;
byte[] result = new byte[1024];
Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
server.Bind(new IPEndPoint(ip, port));
server.Listen(10);
Console.WriteLine("Server start, waiting for access... ");
while (true)
{ 
    Socket client = server.Accept();
    client.Send(Encoding.Default.GetBytes("This is Server"));
    Socket client1 = client;

    while (true)
    {
        try
        {
            int length = client1.Receive(result);
            Console.WriteLine("Access accepted, ID is " + client.RemoteEndPoint.ToString());
            Console.WriteLine("Message From Client: " + Encoding.Default.GetString(result, 0, length));
        }
        catch (Exception ex) 
        { 
            
            Console.WriteLine(ex.ToString());
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}

//private static byte[] result = new byte[1024];
//private static
