using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.Entities;
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class NotesForm : Form
    {
        public static NotesForm instance;
        public NotesForm()
        {
            InitializeComponent();
            Init();
            InitColors();

            instance = this;
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            notesListPanel.BackColor = stinst.backColor;

            addNoteBtn.BackColor = stinst.controlsColor;
            addNoteBtn.ForeColor = stinst.controlsFontColor;
        }

        private void Init()
        {
            instance = this;
            RefreshNotes();
        }

        public void RefreshNotes()
        {
            notesListPanel.Controls.Clear();
            foreach(Note note in DatabaseManager.instance.storedNotes)
            {
                UserControlNotePreview ucnote = new UserControlNotePreview(note);
                notesListPanel.Controls.Add(ucnote);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            string Title = "";
            string Content = "";
            Note note = new Note();
            note.Title = Title;
            note.Content = Content;

            DatabaseManager.instance.AddNote(note);
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
            notesListPanel.Controls.Clear();
        }
    }
}
