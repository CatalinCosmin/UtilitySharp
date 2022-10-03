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
using System.Windows.Media.TextFormatting;
using UtilitySharp.Entities;
using Color = System.Drawing.Color;

namespace UtilitySharp.UserControls
{
    public partial class UserControlCountdown : UserControl
    {
        private List<EventDate> events = new List<EventDate>();
        private Timer t = null;
        private DateTime eventToDateTime;
        public UserControlCountdown()
        {
            InitializeComponent();
            InitColors();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            label1.BackColor = Color.Transparent;
            label1.ForeColor = stinst.backFontColor;

            eventsDropdown.BackColor = stinst.controlsColor;
            eventsDropdown.ForeColor = stinst.controlsFontColor;

            timeDisplay.BackColor = stinst.backColor;
            timeDisplay.ForeColor = stinst.backFontColor;
        }

        private void UserControlCountdown_Load(object sender, EventArgs e)
        {
            foreach(EventDate ev in DatabaseManager.instance.storedEvents)
            {
                string str = ev.Name;
                eventsDropdown.Items.Add(str);
                events.Add(ev);
            }   
        }

        private void eventsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = eventsDropdown.SelectedIndex;
            EventDate ev = events.ElementAt(id);

            eventToDateTime = ev.Date;

            if (DateTime.Now < eventToDateTime)
                StartTimer();
            else
            {
                TimeSpan passed = eventToDateTime - DateTime.Now;
                timeDisplay.Text = "Event passed " + passed.ToString("%d") + " days ago";
            }
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
            TimeSpan countdown = eventToDateTime - DateTime.Now;
            timeDisplay.Text = countdown.ToString("%d") + "  days " + countdown.ToString(@"hh\:mm\:ss\.ff");
        }
    }
}
