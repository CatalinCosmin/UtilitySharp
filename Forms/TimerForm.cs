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
    public partial class TimerForm : Form
    {
        public static TimerForm instance;

        private DateTime currentTime;
        private Timer t = null;
        public TimerForm()
        {
            instance = this;
            InitializeComponent();
            InitColors();
            currentTime = DateTime.Now;

            StartTimer();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;
            this.BackColor = stinst.backColor;
            
            timeDisplay.BackColor = stinst.backColor;
            timeDisplay.ForeColor = stinst.backFontColor;

            textBox1.BackColor = stinst.backColor;
            textBox1.ForeColor = stinst.backFontColor;

            liveHourPanel.BackColor = stinst.backColor;

            stopwatchBtn.BackColor = stinst.controlsColor;
            stopwatchBtn.ForeColor = stinst.controlsFontColor;

            countdownBtn.BackColor = stinst.controlsColor;
            countdownBtn.ForeColor = stinst.controlsFontColor;


        }

        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_tick);
            t.Enabled = true;
        }

        private void t_tick(object sender, EventArgs e)
        {
            timeDisplay.Text = DateTime.Now.ToString();
        }

        private void stopwatchBtn_Click(object sender, EventArgs e)
        {
            UserControlStopwatch usstopwatch = new UserControlStopwatch();
            functionsPanel.Controls.Clear();
            functionsPanel.Controls.Add(usstopwatch);
        }

        private void countdownBtn_Click(object sender, EventArgs e)
        {
            UserControlCountdown uscountdown = new UserControlCountdown();
            functionsPanel.Controls.Clear();
            functionsPanel.Controls.Add(uscountdown);
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
