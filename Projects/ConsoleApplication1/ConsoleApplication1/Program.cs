using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(333);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            Socket server = new Socket(AddressFamily.InterNetwork,
                       SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started");

            counter = 0;
            while (true)
            {
                counter += 1;
                
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(" >> " + "Client No:" + Convert.ToString(counter) + " started!");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, Convert.ToString(counter));
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> " + "exit");
            Console.ReadLine();
        }
    }

    //Class to handle each client request separatly
    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        public static string[] final;

        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[2048];
            string dataFromClient = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    Console.WriteLine(" >> " + "From client-" + clNo +": "+ dataFromClient);
                    final = dataFromClient.Split(' ');
                    string name = "";
                    string time = "";
                    string misses = "";
                    for (int i = 0; i < final.Length; i++)
                    {
                        if (i == 0)
                        {
                            name = final[i];
                        }
                        else if (i == 1)
                        {
                            time = final[i];
                        }
                        else 
                        {
                            misses = final[i];
                        }
                    }
                        MySQL.addToDatabase(name, time, Convert.ToInt32(misses));
                    break;

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}
