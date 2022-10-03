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

namespace UtilitySharp.Forms
{
    public partial class AddEventForm : Form
    {
        private int year, month, day;
        private EventOptionsForm parent;
        public AddEventForm(EventOptionsForm _parent, int _year, int _month, int _day)
        {
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

            label1.BackColor = Color.Transparent;
            label1.ForeColor = stinst.backFontColor;

            txtNameInput.BackColor = stinst.controlsColor;
            txtNameInput.ForeColor = stinst.controlsFontColor;

            addBtn.BackColor = stinst.controlsColor;
            addBtn.ForeColor = stinst.controlsFontColor;

            lbError.Visible = false;
            lbError.ForeColor = stinst.backFontColor;

            label2.BackColor = Color.Transparent;
            label2.ForeColor = stinst.backFontColor;

            label3.BackColor = Color.Transparent;
            label3.ForeColor = stinst.backFontColor;

            label4.BackColor = Color.Transparent;
            label4.ForeColor = stinst.backFontColor;

            hourInput.BackColor = stinst.controlsColor;
            hourInput.ForeColor = stinst.controlsFontColor;

            minuteInput.BackColor = stinst.controlsColor;
            minuteInput.ForeColor = stinst.controlsFontColor;

            secondInput.BackColor = stinst.controlsColor;
            secondInput.ForeColor = stinst.controlsFontColor;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EventDate ev = new EventDate();

            int hour, minute, second;

            try
            {
                hour = Convert.ToInt32(hourInput.Text);
            }
            catch (Exception)
            {
                hour = 0;
            }

            try
            {
                minute = Convert.ToInt32(minuteInput.Text);
            }
            catch (Exception)
            {
                minute = 0;
            }

            try
            {
                second = Convert.ToInt32(secondInput.Text);
            }
            catch (Exception)
            {
                second = 0;
            }

            lbError.Visible = false;

            try
            {
                ev.Date = new DateTime(year, month, day, hour, minute, second);

                ev.Name = txtNameInput.Text;
                DatabaseManager.instance.AddEvent(ev);

                parent.RefreshContent();

                this.Close();
            }
            catch(Exception)
            {
                lbError.Visible = true;
            }
        }
    }
}
