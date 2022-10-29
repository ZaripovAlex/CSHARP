using System.Net.Sockets;
using System.Text;
using System.Net;
namespace Server
{
    class Ourserver
    {
        TcpListener server;
        public Ourserver()
        {
            server= new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);
            server.Start();
            loopClients();
        }
        void loopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread thread = new Thread(()=> HandleCLient(client));
                thread.Start();
            }
        }

        void HandleCLient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            while (true)
            {
                string message= sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {message}"); 
            }
        }

    }

}