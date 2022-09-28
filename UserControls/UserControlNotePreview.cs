using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using UtilitySharp.Entities;
using UtilitySharp.Forms;
using Color = System.Drawing.Color;

namespace UtilitySharp.UserControls
{
    public partial class UserControlNotePreview : UserControl
    {
        private Note note;
        public UserControlNotePreview(Note _note)
        {
            InitializeComponent();

            note = _note;

            InitColors();

        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.controlsColor;

            lbNoteTitle.BackColor = Color.Transparent;
            lbNoteTitle.ForeColor = stinst.controlsFontColor;

            lbContent.BackColor = Color.Transparent;
            lbContent.ForeColor = stinst.controlsFontColor;

            openBtn.BackColor = stinst.controlsColor;
            openBtn.ForeColor = stinst.controlsFontColor;

            noteDelBtn.BackColor = stinst.controlsColor;
            noteDelBtn.ForeColor = stinst.controlsFontColor;
        }

        private void UserControlNotePreview_Load(object sender, EventArgs e)
        {
            RefreshNote();
        }

        private void RefreshNote()
        {
            lbNoteTitle.Text = note.Title;
            lbContent.Text = note.Content;
        }

        private void noteDelBtn_Click(object sender, EventArgs e)
        {
            DatabaseManager.instance.RemoveNote(note.id);
        }

        private void noteOpenBtn_Click(object sender, EventArgs e)
        {
            Form form = new NotePreviewForm(note);
            form.ShowDialog();
        }
    }
}
