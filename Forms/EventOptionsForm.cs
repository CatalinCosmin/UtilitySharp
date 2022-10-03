using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using UtilitySharp.Entities;
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class EventOptionsForm : Form
    {
        public static EventOptionsForm instance;
        private UserControlDays parent;

        private int year, month, day;

        private void button1_Click(object sender, EventArgs e)
        {
            //CalendarForm inst = CalendarForm.instance;
            Form form = new AddEventForm(this, year, month, day);
            form.ShowDialog();
            
        }

        public EventOptionsForm(UserControlDays _parent, int _year, int _month, int _day)
        {
            instance = this;
            parent = _parent;

            year = _year;
            month = _month;
            day = _day;
            InitializeComponent();
            InitColors();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            eventsListPanel.BackColor = stinst.backColor;

            button1.BackColor = stinst.controlsColor;
            button1.ForeColor = stinst.controlsFontColor;
        }

        private void EventOptionsForm_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        public void RefreshContent()
        {
            eventsListPanel.Controls.Clear();
            foreach (EventDate eventDate in DatabaseManager.instance.storedEvents)
            {
                if (eventDate.Date.Year == year && eventDate.Date.Month == month && eventDate.Date.Day == day)
                {
                    UserControlEventOptions ucevent = new UserControlEventOptions(eventDate);
                    eventsListPanel.Controls.Add(ucevent);
                }
            }

            DatabaseManager.instance.eventExists[year, month, day] = (eventsListPanel.Controls.Count > 0);
            parent.LoadEventsToolTip();
        }
    }
}
