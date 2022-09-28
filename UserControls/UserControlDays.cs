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
using UtilitySharp.Forms;

namespace UtilitySharp.UserControls
{
    public partial class UserControlDays : UserControl
    {
        private int value;
        public UserControlDays(int number)
        {
            InitializeComponent();
            daysText.Text = number.ToString();
            value = number;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            LoadEventsToolTip();
        }

        public void LoadEventsToolTip()
        {
            CalendarForm inst = CalendarForm.instance;
            if (DatabaseManager.instance.eventExists[inst.year, inst.month, value])
            {
                label1.Visible = true;
                this.BackColor = SettingsManager.instance.highlightedControlsColor;
            }
            else
            {
                label1.Visible = false;
                this.BackColor = SettingsManager.instance.controlsColor;
            }
            daysText.ForeColor = SettingsManager.instance.controlsFontColor;
            label1.ForeColor = SettingsManager.instance.controlsFontColor;
            daysText.ForeColor = SettingsManager.instance.controlsFontColor;
        }
        private void AddEvent(object sender, EventArgs e)
        {
            CalendarForm inst = CalendarForm.instance;
            EventOptionsForm form = new EventOptionsForm(this, inst.year, inst.month, value);
            //Form form = new AddEventForm(inst.year, inst.month, value);
            form.ShowDialog();
        }
    }
}
