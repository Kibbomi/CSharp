using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CSharp
{
    class Socket_Echo_Server
    {
        static void Main(string[] args)
        {
            IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse("172.16.163.188"), 9876);

            TcpListener server = new TcpListener(localAddress);

            server.Start();
            Console.WriteLine("Echo Server On");

            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();    //blocked... It waits client's connection

                    NetworkStream ns = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];

                    while ((length = ns.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.Default.GetString(bytes, 0, length);
                        Console.WriteLine($"수신 : {data}");

                        byte[] msg = Encoding.Default.GetBytes(data);
                        ns.Write(msg, 0, msg.Length);
                        Console.WriteLine($"송신 : {data}");
                    }
                    ns.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
