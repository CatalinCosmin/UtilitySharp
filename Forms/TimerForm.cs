using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class TimerForm : Form
    {
        private DateTime currentTime;
        private Timer t = null;
        public TimerForm()
        {
            InitializeComponent();
            currentTime = DateTime.Now;

            StartTimer();
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
    }
}
