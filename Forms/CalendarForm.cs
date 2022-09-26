using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class CalendarForm : Form
    {

        public static CalendarForm instance;
        public int month, year;

        public CalendarForm()
        {
            instance = this;
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            displayDays();
        }

        private void displayDays()
        {
            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            // set year and month uptop
            lbyearmonth.Text = MonthName(month) + "  " + year.ToString();

            // set greyed out days
            int prevDays;
            if (month > 1)
                prevDays = DateTime.DaysInMonth(year, month - 1);
            else
                prevDays = DateTime.DaysInMonth(year - 1, 12);
            for (int i = 1; i < dayOfTheWeek; ++i)
            {
                UserControlBlank ucblank = new UserControlBlank(prevDays - (dayOfTheWeek - i) + 1);
                dayContainer.Controls.Add(ucblank);
            }

            // set month days
            for (int i = 1; i <= days; ++i)
            {
                UserControlDays ucdays = new UserControlDays(i);
                dayContainer.Controls.Add(ucdays);
            }

            // set greyed out days
            for (int i = 1; i <= 42 - (days + dayOfTheWeek - 1); ++i)
            {
                UserControlBlank ucblank = new UserControlBlank(i);
                dayContainer.Controls.Add(ucblank);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;
            if(month > 12)
            {
                year++;
                month = 1;
            }
            displayDays();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }
            displayDays();
        }

        private string MonthName(int month)
        {
            return new DateTime(year, month, 1).ToString("MMM");
        }
    }
}
