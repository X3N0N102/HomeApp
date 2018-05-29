using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace HomeApp
{
    public class Database
    {
        private MySqlConnection db_conn;
        private static MySqlCommand db_command;

        public Database(string server_ip, string database_name, string username, string password)
        {
            try
            {
                string connectionString = $"SERVER={server_ip};PORT=3306;DATABASE={database_name};UID={username};PASSWORD={password};";

                db_conn = new MySqlConnection();
                db_conn.ConnectionString = connectionString;
                db_command = db_conn.CreateCommand();
                db_conn.Open();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable Query(string query)
        {
            DataTable results = new DataTable();

            db_command.CommandText = query;

            MySqlDataReader reader = db_command.ExecuteReader();
            results.Load(reader);

            return results;
        }
    }
}
