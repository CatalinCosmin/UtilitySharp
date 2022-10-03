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

            SettingsManager stinst = SettingsManager.instance;

            if (DatabaseManager.instance.eventExists[inst.year, inst.month, value])
            {
                label1.Visible = true;
                backPanel.BackColor = stinst.highlightedControlsColor;
                this.BackColor = stinst.highlightedControlsColor;
                if(DateTime.Now.Day == value)
                    this.BackColor = Color.FromArgb(255 - stinst.highlightedControlsColor.R, 255 - stinst.highlightedControlsColor.G, 255 - stinst.highlightedControlsColor.B);
                
            }
            else
            {
                label1.Visible = false;
                backPanel.BackColor = stinst.controlsColor;
                this.BackColor = stinst.controlsColor;
                if(DateTime.Now.Day == value)
                    this.BackColor = Color.FromArgb(255 - stinst.controlsColor.R, 255 - stinst.controlsColor.G, 255 - stinst.controlsColor.B);
            }

            daysText.ForeColor = stinst.controlsFontColor;
            label1.ForeColor = stinst.controlsFontColor;
            daysText.ForeColor = stinst.controlsFontColor;
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
