using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Clicky_Game
{
    class Socketing
    {

        public static long score = 0;
        public static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void sendScore()
        {
            byte[] data = new byte[1024];
            

            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 333);
            TcpListener serverSocket = new TcpListener(333);

            try
            {
                server.Connect(IP);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to the server.");
                Console.WriteLine(e.ToString());
                return;
            }

            Console.WriteLine("Getting there");

            
            
            server.Send(Encoding.ASCII.GetBytes(score.ToString()));
            //server.Close();
           
                
        }
    }
}
