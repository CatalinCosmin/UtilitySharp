using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.Entities;
using UtilitySharp.Forms;

namespace UtilitySharp.UserControls
{
    public partial class UserControlEventOptions : UserControl
    {
        EventDate eventDate;

        public UserControlEventOptions(EventDate _eventDate)
        {
            eventDate = _eventDate;
            InitializeComponent();
            InitColors();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.controlsColor;

            lbDescription.BackColor = Color.Transparent;
            lbDescription.ForeColor = stinst.controlsFontColor;

            btnModify.BackColor = stinst.controlsColor;
            btnModify.ForeColor = stinst.controlsFontColor;

            btnRemove.BackColor = stinst.controlsColor;
            btnRemove.ForeColor = stinst.controlsFontColor;
        }

        private void UserControlEventOptions_Load(object sender, EventArgs e)
        {
            lbDescription.Text = eventDate.Name;
            hourDisplay.Text = eventDate.Date.Hour.ToString("00") + ":" + eventDate.Date.Minute.ToString("00") + ":" + eventDate.Date.Second.ToString("00");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DatabaseManager.instance.RemoveEvent(eventDate.id);
        }
    }
}
