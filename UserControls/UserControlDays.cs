using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void AddEvent(object sender, EventArgs e)
        {
            CalendarForm inst = CalendarForm.instance;
            EventOptionsForm form = new EventOptionsForm(inst.year, inst.month, value);
            //Form form = new AddEventForm(inst.year, inst.month, value);
            form.ShowDialog();
        }
    }
}
