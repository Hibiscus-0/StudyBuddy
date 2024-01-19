using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudyBuddy
{
    

    internal class databaseConnector
    {
        private string connectionString = "Server=%;Database=StudyBuddy;User Id=sbAdmin;Password=-fCd-eIxp6rAk!Dm;";

        databaseConnector()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
        }
    }
}
