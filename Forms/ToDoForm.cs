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
using UtilitySharp.UserControls;

namespace UtilitySharp.Forms
{
    public partial class ToDoForm : Form
    {
        public static ToDoForm instance;
        public ToDoForm()
        {
            instance = this;
            InitializeComponent();
            InitColors();
            RefreshContent();
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            contentPanel.BackColor = stinst.backColor;

            addBtn.BackColor = stinst.controlsColor;
            addBtn.ForeColor = stinst.controlsFontColor;
        }

        public void RefreshContent()
        {
            contentPanel.Controls.Clear();
            foreach(ToDo t in DatabaseManager.instance.storedToDo)
            {
                UserControlToDo uctodo = new UserControlToDo(t);
                contentPanel.Controls.Add(uctodo);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserControlToDo uctodo = new UserControlToDo(new ToDo());
            contentPanel.Controls.Add(uctodo);

            DatabaseManager.instance.AddToDo(new ToDo());
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
