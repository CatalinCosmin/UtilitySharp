using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace UtilitySharp.Entities
{
    public class DatabaseManager
    {
        public static DatabaseManager instance;
        private SqlConnection con;

        public List<EventDate> storedEvents = new List<EventDate>();

        public bool[,,] eventExists = new bool[2150, 13, 32];

        
        public DatabaseManager()
        {
            instance = this;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            InitEvents();
        }

        private void InitEvents()
        {

            using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Events", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            EventDate e = new EventDate();
                            e.Name = reader.GetString(1);
                            e.Year = reader.GetInt32(2);
                            e.Month = reader.GetInt32(3);
                            e.Day = reader.GetInt32(4);

                            eventExists[e.Year, e.Month, e.Day] = true;

                            storedEvents.Add(e);
                        }
                }
            }
        }

        public void AddEvent(EventDate e)
        {
            storedEvents.Add(e);

            using(SqlCommand cmd = new SqlCommand(@"INSERT INTO Events (Name, Year, Month, Day) VALUES (@name, @year, @month, @day)", DatabaseManager.instance.con))
            {
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@year", e.Year);
                cmd.Parameters.AddWithValue("@month", e.Month);
                cmd.Parameters.AddWithValue("@day", e.Day);

                cmd.ExecuteNonQuery();
            }
        }
    }

}

public struct EventDate
{
    public string Name;
    public int Year;
    public int Month;
    public int Day;
};
