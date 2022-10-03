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
        public int currentEventIndex;

        public bool[,,] eventExists = new bool[2150, 13, 32];

        public List<Note> storedNotes = new List<Note>();

        public List<ToDo> storedToDo = new List<ToDo>();

        
        public DatabaseManager()
        {
            instance = this;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            InitEvents();
            InitNotes();
            InitToDo();
        }

        private void InitEvents()
        {

            using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Events ORDER BY Date", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            EventDate e = new EventDate();
                            e.id = reader.GetInt32(0);
                            e.Name = reader.GetString(1);
                            e.Date = Convert.ToDateTime(reader.GetDateTime(2));

                            eventExists[e.Date.Year, e.Date.Month, e.Date.Day] = true;

                            storedEvents.Add(e);
                        }
                }
            }

            currentEventIndex = 0;
            while (storedEvents[currentEventIndex].Date < DateTime.Now)
                currentEventIndex++;

        }

        public void AddEvent(EventDate e)
        {
            int index = 0;
            while (storedEvents[index].Date < e.Date)
                index++;
            storedEvents.Insert(index, e);
            eventExists[e.Date.Year, e.Date.Month, e.Date.Day] = true;

            Form1.instance.SetNextEventNotification();

            using(SqlCommand cmd = new SqlCommand(@"INSERT INTO Events (Name, Date) VALUES (@name, @date); SELECT SCOPE_IDENTITY()", con))
            {
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@date", e.Date);

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
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Notes (Title, Content) VALUES (@title, @content); SELECT SCOPE_IDENTITY()", DatabaseManager.instance.con))
            {
                cmd.Parameters.AddWithValue("@title", note.Title);
                cmd.Parameters.AddWithValue("@content", note.Content);

                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                note.id = insertedID;
                
            }
            storedNotes.Add(note);
            NotesForm.instance.RefreshNotes();
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
                    n.Title = note.Title;
                    n.Content = note.Content;
                }
            }

            NotesForm.instance.RefreshNotes();
        }


        private void InitToDo()
        {
            using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM ToDo", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            ToDo t = new ToDo();
                            t.id = reader.GetInt32(0);
                            t.Text = reader.GetString(1);
                            t.isChecked = reader.GetBoolean(2);

                            storedToDo.Add(t);
                        }
                }
            }
        }


        public void AddToDo(ToDo t)
        {
            t.Text = "";
            t.isChecked = false;
            using(SqlCommand cmd = new SqlCommand(@"INSERT INTO ToDo (Text, Checked) VALUES (@text, @checked); SELECT SCOPE_IDENTITY()", con))
            {
                cmd.Parameters.AddWithValue("@text", t.Text);
                cmd.Parameters.AddWithValue("@checked", t.isChecked);

                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                t.id = insertedID;

                Console.WriteLine(t.id);
                storedToDo.Add(t);
            }
        }

        public void RemoveToDo(int id)
        {
            using (SqlCommand cmd = new SqlCommand(@"DELETE FROM ToDo WHERE idToDo = @id", con))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();

                var todo = storedToDo.First(item => item.id == id);
                storedToDo.Remove(todo);
                ToDoForm.instance.RefreshContent();
            }
        }

        public void UpdateToDo(ToDo t)
        {
            using (SqlCommand cmd = new SqlCommand(@"UPDATE ToDo SET Text = @text, Checked = @checked WHERE idToDo = @id", con))
            {
                cmd.Parameters.AddWithValue("id", t.id);
                cmd.Parameters.AddWithValue("text", t.Text);
                cmd.Parameters.AddWithValue("checked", t.isChecked);
                cmd.ExecuteNonQuery();
            }

            

            for (int i = 0; i < storedToDo.Count; ++i)
            {
                ToDo todo = storedToDo.ElementAt(i);
                if (todo.id == t.id)
                {
                    todo.Text = t.Text + " " + todo.id;
                    todo.isChecked = t.isChecked;
                }
            }

            ToDoForm.instance.RefreshContent();
        }
    }

}

public class EventDate
{
    public int id;
    public string Name;
    public DateTime Date;
};

public class Note
{
    public int id;
    public string Title;
    public string Content;
};

public class ToDo
{
    public int id;
    public string Text;
    public bool isChecked;
};