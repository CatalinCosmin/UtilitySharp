using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitySharp.Entities
{
    public class DatabaseManager
    {
        public static DatabaseManager instance;
        private SqlConnection con;
        public DatabaseManager()
        {
            instance = this;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            Console.WriteLine("db set");
        }
    }
}
