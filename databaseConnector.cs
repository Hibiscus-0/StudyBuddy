using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudyBuddy
{
    

    internal class databaseConnector
    {
        private string connectionString = "Datasource=localhost;Port=3306;Database=StudyBuddy;Username=sbAdmin;Password=-fCd-eIxp6rAk!Dm;";
        MySqlConnection connection;

        public databaseConnector()
        {
            connection = new MySqlConnection(connectionString);
        } 

        private void OpenConnection()
        {
            connection.Open();
        }

        private void CloseConnection()
        {
            connection.Close();
        }

        public Boolean Authenticate(string username, string password)
        {
            Boolean isTrue = false;
            OpenConnection();
            string query = $"SELECT (password) FROM useraccounts WHERE username = @Username OR email = @Username;";
            MySqlCommand selectCommand = new MySqlCommand(query, connection);
            selectCommand.Parameters.AddWithValue("@Username", username);
            using (MySqlDataReader reader = selectCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    if(password == reader["password"].ToString())
                    {
                        isTrue = true;
                    }
                }
            }

            CloseConnection();

            return isTrue;
        }
        
    }
}
