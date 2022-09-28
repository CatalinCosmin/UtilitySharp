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

namespace UtilitySharp.Forms
{
    public partial class NotePreviewForm : Form
    {
        public static NotePreviewForm instance;
        private Note note;
        public NotePreviewForm(Note _note)
        {
            InitializeComponent();
            InitColors();

            instance = this;

            note = _note;
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            titleDisplay.BackColor = stinst.controlsColor;
            titleDisplay.ForeColor = stinst.controlsFontColor;

            contentDisplay.BackColor = stinst.controlsColor;
            contentDisplay.ForeColor = stinst.controlsFontColor;

            saveTitleBtn.BackColor = stinst.controlsColor;
            saveTitleBtn.ForeColor = stinst.controlsFontColor;

            saveContentBtn.BackColor = stinst.controlsColor;
            saveContentBtn.ForeColor = stinst.controlsFontColor;
        }

        private void NotePreviewForm_Load(object sender, EventArgs e)
        {
            titleDisplay.Text = note.Title;
            contentDisplay.Text = note.Content;
        }

        private void titleDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void contentDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveTitleBtn_Click(object sender, EventArgs e)
        {
            note.Title = titleDisplay.Text;
            DatabaseManager.instance.UpdateNote(note);
        }

        private void saveContentBtn_Click(object sender, EventArgs e)
        {
            note.Content = contentDisplay.Text;
            DatabaseManager.instance.UpdateNote(note);
        }
    }
}
