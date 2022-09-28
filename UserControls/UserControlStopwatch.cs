using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using UtilitySharp.Entities;
using Timer = System.Windows.Forms.Timer;

namespace UtilitySharp.UserControls
{
    public partial class UserControlStopwatch : UserControl
    {
        private DateTime initTime;
        private TimeSpan current;
        private Timer t = null;
        private bool cleared = true;
        public UserControlStopwatch()
        {
            InitializeComponent();
            InitColors();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            timeDisplay.BackColor = stinst.backColor;
            timeDisplay.ForeColor = stinst.backFontColor;

            startBtn.BackColor = stinst.controlsColor;
            startBtn.ForeColor = stinst.controlsFontColor;

            lapBtn.BackColor = stinst.controlsColor;
            lapBtn.ForeColor = stinst.controlsFontColor;

            pauseBtn.BackColor = stinst.controlsColor;
            pauseBtn.ForeColor = stinst.controlsFontColor;

            clearBtn.BackColor = stinst.controlsColor;
            clearBtn.ForeColor = stinst.controlsFontColor;

            lapsPanel.BackColor = stinst.backColor;
        }

        private void UserControlStopwatch_Load(object sender, EventArgs e)
        {
            InitStopwatch();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(cleared == true)
            {
                initTime = DateTime.Now;
                cleared = false;
            }
            StartTimer();
        }

        private void StartTimer()
        {
            if (t == null)
            {
                t = new Timer();
                t.Interval = 1;
                t.Tick += new EventHandler(t_tick);
            }
            t.Enabled = true;
        }

        private void t_tick(object sender, EventArgs e)
        {
            current = DateTime.Now - initTime;
            timeDisplay.Text = current.ToString(@"hh\:mm\:ss\.fff");
        }

        private void lapBtn_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Font = new Font("Impact", 10);
            label.Text = current.ToString(@"hh\:mm\:ss\.fff");
            label.BackColor = Color.Transparent;
            label.ForeColor = SettingsManager.instance.backFontColor;
            lapsPanel.Controls.Add(label);
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cleared = true;
            lapsPanel.Controls.Clear();
            t.Dispose();
            InitStopwatch();
        }

        private void InitStopwatch()
        {
            timeDisplay.Text = "00:00:00.000";
        }
    }
}
