using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ql_tiem_chung
{
    public partial class TestConnectionDB : Form
    {
        public TestConnectionDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "ql_tiem_chung";
            string username = "root";
            string password = "123456";
            string connectionString = "SERVER=" + server + ";DATABASE=" + database 
                + ";UID=" + username + ";PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "select * from tai_khoan";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                MessageBox.Show(data.GetString(0));
            }
        }
    }
}
