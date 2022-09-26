using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.Entities;
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class EventOptionsForm : Form
    {
        private int year, month, day;

        private void button1_Click(object sender, EventArgs e)
        {
            //CalendarForm inst = CalendarForm.instance;
            Form form = new AddEventForm(year, month, day);
            form.ShowDialog();
        }

        public EventOptionsForm(int _year, int _month, int _day)
        {
            year = _year;
            month = _month;
            day = _day;
            InitializeComponent();
        }

        private void EventOptionsForm_Load(object sender, EventArgs e)
        {
            foreach(EventDate eventDate in DatabaseManager.instance.storedEvents)
            {
                if(eventDate.Year == year && eventDate.Month == month && eventDate.Day == day)
                {
                    UserControlEventOptions ucevent = new UserControlEventOptions(eventDate.Name);
                    eventsListPanel.Controls.Add(ucevent);
                }    
            }
        }
    }
}
