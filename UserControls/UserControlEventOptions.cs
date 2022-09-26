using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitySharp.UserControls
{
    public partial class UserControlEventOptions : UserControl
    {
        string description;
        public UserControlEventOptions(string _description)
        {
            description = _description;
            InitializeComponent();
        }

        private void UserControlEventOptions_Load(object sender, EventArgs e)
        {
            lbDescription.Text = description;
        }
    }
}
