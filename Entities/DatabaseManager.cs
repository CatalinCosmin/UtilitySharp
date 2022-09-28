using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using UtilitySharp.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UtilitySharp.Entities
{
    public class DatabaseManager
    {
        public static DatabaseManager instance;
        public SqlConnection con;

        public List<EventDate> storedEvents = new List<EventDate>();

        public bool[,,] eventExists = new bool[2150, 13, 32];

        public List<Note> storedNotes = new List<Note>();

        
        public DatabaseManager()
        {
            instance = this;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            InitEvents();
            InitNotes();
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
                            e.id = reader.GetInt32(0);
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

                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                e.id = insertedID;
            }
        }

        public void RemoveEvent(int eventId)
        {
            using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Events WHERE idEvent = @id;", con))
            {
                cmd.Parameters.AddWithValue("id", eventId);
                cmd.ExecuteNonQuery();

                var ev = storedEvents.First(item => item.id == eventId);
                storedEvents.Remove(ev);

                EventOptionsForm.instance.RefreshContent();
            }
        }

        public void InitNotes()
        {
            using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Notes", con))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Note note = new Note();
                            note.id = reader.GetInt32(0);
                            note.Title = reader.GetString(1);
                            note.Content = reader.GetString(2);
                            storedNotes.Add(note);
                        }
                    }
                }
            }
        }

        public void AddNote(Note note)
        {
            storedNotes.Add(note);
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Notes (Title, Content) VALUES (@title, @content)", DatabaseManager.instance.con))
            {
                cmd.Parameters.AddWithValue("@title", note.Title);
                cmd.Parameters.AddWithValue("@content", note.Content);

                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                note.id = insertedID;
                NotesForm.instance.RefreshNotes();
            }
        }

        public void RemoveNote(int id)
        {
            using(SqlCommand cmd = new SqlCommand(@"DELETE FROM Notes WHERE idNote = @id", con))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();

                var note = storedNotes.First(item => item.id == id);
                storedNotes.Remove(note);
                NotesForm.instance.RefreshNotes();
            }
        }

        public void UpdateNote(Note note)
        {
            using (SqlCommand cmd = new SqlCommand(@"UPDATE Notes SET Title = @title, Content = @content WHERE idNote = @id", con))
            {
                cmd.Parameters.AddWithValue("id", note.id);
                cmd.Parameters.AddWithValue("title", note.Title);
                cmd.Parameters.AddWithValue("content", note.Content);
                cmd.ExecuteNonQuery();
            }

            for (int i = 0; i < storedNotes.Count; ++i)
            {
                Note n = storedNotes.ElementAt(i);
                if (n.id == note.id)
                {
                    storedNotes.RemoveAt(i);
                }
            }
            storedNotes.Add(note);

            NotesForm.instance.RefreshNotes();
        }
    }

}

public struct EventDate
{
    public int id;
    public string Name;
    public int Year;
    public int Month;
    public int Day;
};

public struct Note
{
    public int id;
    public string Title;
    public string Content;
}
