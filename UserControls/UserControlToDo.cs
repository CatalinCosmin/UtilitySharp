using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitySharp.Entities;

namespace UtilitySharp.UserControls
{
    public partial class UserControlToDo : UserControl
    {
        private ToDo toDo;
        public UserControlToDo(ToDo toDo)
        {
            InitializeComponent();
            InitColors();
            this.toDo = toDo;
            InitContent();
        }

        private void InitContent()
        {
            checkBox.Checked = Convert.ToBoolean(toDo.isChecked);
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.controlsColor;

            checkBox.BackColor = stinst.controlsColor;

            ToDoDisplay.BackColor = stinst.controlsColor;
            ToDoDisplay.ForeColor = stinst.controlsFontColor;

            delBtn.BackColor = stinst.controlsColor;
            delBtn.ForeColor = stinst.controlsFontColor;

            modBtn.BackColor = stinst.controlsColor;
            modBtn.ForeColor = stinst.controlsFontColor;
        }

        private void UserControlToDo_Load(object sender, EventArgs e)
        {
            ToDoDisplay.Text = toDo.Text;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DatabaseManager.instance.RemoveToDo(toDo.id);
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            toDo.Text = ToDoDisplay.Text;
            toDo.isChecked = checkBox.Checked;
            DatabaseManager.instance.UpdateToDo(toDo);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
