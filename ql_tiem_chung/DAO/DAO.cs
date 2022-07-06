using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ql_tiem_chung.DAO
{
    public class DAO
    {
        private string connectionString = "SERVER=localhost;DATABASE=ql_tiem_chung;UID=root;PASSWORD=123456;";
        
        public DataTable query(string query)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            
            return data;
        }

        public long queryInsert(string query)
        {
            long id;
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                id = command.LastInsertedId;
                connection.Close();
            }

            return id;
        }
    }
}
