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
        public AddEventForm(int _year, int _month, int _day)
        {
            year = _year;
            month = _month;
            day = _day;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventDate ev = new EventDate();
            ev.Year = year;
            ev.Month = month;
            ev.Day = day;
            ev.Name = txtNameInput.Text;
            DatabaseManager.instance.AddEvent(ev);
            this.Close();
        }
    }
}
