using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CharsConsole
{
    class Console18ChatClient
    {
        private static byte[] result = new byte[1024];

        public void receiveMessage()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            Socket client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            try
            {
                client.Connect(new IPEndPoint(ipAddress, 100));
                Console.WriteLine("Connect to the server");
            }
            catch (Exception ex)

            {
                Console.WriteLine("Failed to connect the server");
                return;
            }
            int data = client.Receive(result);
            Console.WriteLine("Message from server: "+Encoding.Default.GetString(result, 0,data));
            try
            {
                string sendMsg = "This is client";
                client.Send(Encoding.Default.GetBytes(sendMsg));
            }
            catch
            { 
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
        }
    }
}
