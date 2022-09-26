using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitySharp.Forms
{
    public partial class TimerForm : Form
    {
        private DateTime currentTime;
        Timer t = null;
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
    }
}
