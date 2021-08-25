using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Socket_Echo_Client
    {
        static void Main(string[] args)
        {
          
            IPEndPoint ClientAddress = new IPEndPoint(IPAddress.Parse("172.16.163.188"), 0);
            TcpClient client = new TcpClient(ClientAddress);

            IPEndPoint ServerAddress = new IPEndPoint(IPAddress.Parse("172.16.163.188"), 9876);
            client.Connect(ServerAddress);
            Console.WriteLine("Connect to server whose ipAddr is 172.16.163.188:9876");

            try
            {
                Console.Write("input string :");
                string message = Console.ReadLine();

                byte[] data = Encoding.Default.GetBytes(message);

                NetworkStream ns = client.GetStream();
                ns.Write(data, 0, data.Length);

                Console.WriteLine($"Send : {message}");

                data = new byte[256];
                string responseData = "";
                int bytes = ns.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
                Console.WriteLine($"Receive : {responseData}");

                ns.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Client is terminated");

        }
    }
}
