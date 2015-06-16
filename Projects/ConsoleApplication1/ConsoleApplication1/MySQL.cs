using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class MySQL
    {

        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        public static void addToDatabase(String name, String score)
        {
            Random random = new Random();
            server = "localhost";
            database = "scores";
            uid = "Root";
            password = "Udhsn83nudH";
            string connectionString;
            connectionString = "server=127.0.0.1;uid=root;" + "pwd=Udhsn83nudH;database=scores;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO scores (id, name, score) VALUES('"+random.Next(0, 50)+"', 'h', '"+Convert.ToInt32(score)+"')";


            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
