using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class MySQL
    {

        private static MySqlConnection connection;

        public static void addToDatabase(String name, String score, int misses)
        {
            Random random = new Random();
            string connectionString;
            connectionString = "server=127.0.0.1;uid=root;" + "pwd=Udhsn83nudH;database=scores;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
<<<<<<< HEAD
=======
            string query = "SELECT LAST_INSERT_ID()"
            
            string query = "INSERT INTO scores (id, name, score) VALUES('"+random.Next(0, 50)+"', 'h', '"+Convert.ToInt32(score)+"')";
>>>>>>> origin/master

            string query = "INSERT INTO times (name, time, misses) VALUES('"+name+"', '" + Convert.ToInt32(score) + "', '"+misses+"')";

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
            IDataRead read = cmd.ExecuteReader();
            
            
            //Execute command
            cmd.ExecuteNonQuery();

            query = "SELECT * FROM times WHERE time=(SELECT MAX(time) FROM times)";

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string data1 = reader.GetString("id");
                string data2 = reader.GetString("name");
                Console.WriteLine(data1 + data2);
            }


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
