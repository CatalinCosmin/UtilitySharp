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

        private int year, month, day;

        private void button1_Click(object sender, EventArgs e)
        {
            //CalendarForm inst = CalendarForm.instance;
            Form form = new AddEventForm(this, year, month, day);
            form.ShowDialog();
            
        }

        public EventOptionsForm(int _year, int _month, int _day)
        {
            instance = this;

            year = _year;
            month = _month;
            day = _day;
            InitializeComponent();
        }

        private void EventOptionsForm_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        public void RefreshContent()
        {
            eventsListPanel.Controls.Clear();
            foreach (var ucevent in from EventDate eventDate in DatabaseManager.instance.storedEvents
                                    where eventDate.Year == year && eventDate.Month == month && eventDate.Day == day
                                    let ucevent = new UserControlEventOptions(eventDate.id, eventDate.Name)
                                    select ucevent)
            {
                eventsListPanel.Controls.Add(ucevent);
            }
        }
    }
}
