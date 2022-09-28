using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using UtilitySharp.Entities;
using UtilitySharp.Forms;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using Point = System.Drawing.Point;
using Microsoft.Win32;
using Application = System.Windows.Forms.Application;

namespace UtilitySharp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DatabaseManager dbInstance;
        public SettingsManager settingsInstance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            this.Location = new Point(0, 0);
            dbInstance = new DatabaseManager();
            settingsInstance = new SettingsManager();

            SetStartup();
        }

        public void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (SettingsManager.instance.runOnStartup == true)
                rk.SetValue("UtilitySharp", Application.ExecutablePath);
            else
                rk.DeleteValue("UtilitySharp", false);
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.Alt)
                if (e.KeyCode == Keys.D)
                    Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            notifyIcon1.BalloonTipTitle = "UtilitySharp";
            notifyIcon1.BalloonTipText = "I am now in system tray.";
            notifyIcon1.Text = "UtilitySharp";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(SettingsManager.instance != null)
                if (SettingsManager.instance.systemTray == true)
                {
                    if (WindowState == FormWindowState.Minimized)
                    {
                        this.Hide();
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(1);
                    }
                    else if (this.WindowState == FormWindowState.Normal)
                    {
                        notifyIcon1.Visible = false;
                    }
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// WIP
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// WIP
        }

        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (CalculatorForm.instance == null)
            {
                Form form = new CalculatorForm();
                form.Show();
            }
        }

        private void cldnBtn_Click(object sender, EventArgs e)
        {
            if (CalendarForm.instance == null)
            { 
                Form form = new CalendarForm();
                form.Show();
            }
        }

        private void timerBtn_Click(object sender, EventArgs e)
        {
            if (TimerForm.instance == null)
            {
                Form form = new TimerForm();
                form.Show();
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calcBtn_Click(sender, new EventArgs());
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cldnBtn_Click(sender, new EventArgs());
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerBtn_Click(sender, new EventArgs());
        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            if (NotesForm.instance == null)
            {
                Form form = new NotesForm();
                form.Show();
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if(SettingsForm.instance == null)
            {
                Form form = new SettingsForm();
                form.ShowDialog();
            }
        }
    }
}
