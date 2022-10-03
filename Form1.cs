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
using System.Security.AccessControl;

namespace UtilitySharp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DatabaseManager dbInstance;
        public SettingsManager settingsInstance;

        private Image calcImage;
        private Image cldnImage;
        private Image timerImage;
        private Image notesImage;
        private Image todoImage;
        private Image settingsImage;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            this.Location = new Point(0, 0);
            dbInstance = new DatabaseManager();
            settingsInstance = new SettingsManager();

            InitImages();

            InitColors();

            SetStartup();

            SetEventNotification();
        }

        private void SetEventNotification()
        {
            SetNextEventNotification();
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }

        public void SetNextEventNotification()
        {
            EventDate _event = DatabaseManager.instance.storedEvents[DatabaseManager.instance.currentEventIndex];

            systemTrayIcon.BalloonTipTitle = "UtilitySharp";
            systemTrayIcon.BalloonTipText = _event.Name + " now(" + _event.Date + ")";
            systemTrayIcon.Text = "UtilitySharp";
        }
        private void timer_tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            DateTime _event = DatabaseManager.instance.storedEvents[DatabaseManager.instance.currentEventIndex].Date;

            //Console.WriteLine(current - _event);

            if (current >= _event)
            {
                //Console.WriteLine("time passed");
                systemTrayIcon.ShowBalloonTip(1);
                DatabaseManager.instance.currentEventIndex++;
            }
        }

        private void InitImages()
        {
            calcImage = calcBtn.BackgroundImage;
            cldnImage = cldnBtn.BackgroundImage;
            timerImage = timerBtn.BackgroundImage;
            notesImage = notesBtn.BackgroundImage;
            todoImage = todoBtn.BackgroundImage;
            settingsImage = settingsBtn.BackgroundImage;
        }

        public void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            InitImage(calcBtn, calcImage);
            InitImage(cldnBtn, cldnImage);
            InitImage(timerBtn, timerImage);
            InitImage(notesBtn, notesImage);
            InitImage(todoBtn, todoImage);
            InitImage(settingsBtn, settingsImage);
        }

        private void InitImage(Button btn, Image im)
        {
            Bitmap bitmap = new Bitmap(im);

            Rectangle rect = new Rectangle(0, 0, 60, 60);

            Bitmap cloneImage = bitmap.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);

            for(int i = 0; i < bitmap.Height; i++)
                for(int j = 0; j < bitmap.Width; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    if (pixelColor == Color.FromArgb(255, 255, 255, 255))
                        pixelColor = SettingsManager.instance.controlsColor;
                    else
                        pixelColor = SettingsManager.instance.controlsFontColor;

                    cloneImage.SetPixel(i, j, pixelColor);
                }

            btn.BackgroundImage = cloneImage;
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
            systemTrayIcon.BalloonTipTitle = "UtilitySharp";
            systemTrayIcon.BalloonTipText = "I am now in system tray.";
            systemTrayIcon.Text = "UtilitySharp";
        }

        private void systemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            systemTrayIcon.Visible = true;
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
                        systemTrayIcon.Visible = true;
                        systemTrayIcon.ShowBalloonTip(1);
                    }
                    else if (this.WindowState == FormWindowState.Normal)
                    {
                        systemTrayIcon.Visible = false;
                    }
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsBtn_Click(sender, new EventArgs());
        }


        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoBtn_Click(sender, new EventArgs());
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

        private void todoBtn_Click(object sender, EventArgs e)
        {
            if(ToDoForm.instance == null)
            {
                Form form = new ToDoForm();
                form.Show();
            }
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notesBtn_Click(sender, new EventArgs());
        }
    }
}
