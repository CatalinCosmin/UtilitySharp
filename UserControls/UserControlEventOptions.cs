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
        int eventId;
        string description;

        public UserControlEventOptions(int id, string _description)
        {
            eventId = id;
            description = _description;
            InitializeComponent();
        }

        private void UserControlEventOptions_Load(object sender, EventArgs e)
        {
            lbDescription.Text = description;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DatabaseManager.instance.RemoveEvent(eventId);
        }
    }
}
