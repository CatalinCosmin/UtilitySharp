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
        }

        private void UserControlEventOptions_Load(object sender, EventArgs e)
        {
            lbDescription.Text = eventDate.Name;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DatabaseManager.instance.RemoveEvent(eventDate.id);
        }
    }
}
