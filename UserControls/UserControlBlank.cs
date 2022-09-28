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

namespace UtilitySharp.UserControls
{
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank(int number)
        {
            InitializeComponent();
            daysText.Text = number.ToString();
            Color color = SettingsManager.instance.controlsColor;
            this.BackColor = Color.FromArgb(125, color);

            daysText.ForeColor = SettingsManager.instance.controlsFontColor;
        }

        public void SetDayNumber(int number)
        {
            daysText.Text = number.ToString();
        }
    }
}
