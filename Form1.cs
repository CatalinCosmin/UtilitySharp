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

namespace UtilitySharp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DatabaseManager dbInstance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            this.Location = new Point(0, 0);
            dbInstance = new DatabaseManager();
            label1.Text = dbInstance.storedEvents.Count.ToString();

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
            if(WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1);
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new CalculatorForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new CalendarForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new TimerForm();
            form.Show();
        }
    }
}
