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

namespace UtilitySharp.Forms
{
    public partial class CalculatorForm : Form
    {
        public static CalculatorForm instance;

        private string operation = "";
        private double stored_number, second_number;
        private string last_operation = "";

        public CalculatorForm()
        {
            instance = this;

            stored_number = 0;
            second_number = 0;
            InitializeComponent();
            InitColors();
        }

        private void InitColors()
        {
            this.BackColor = SettingsManager.instance.backColor;
            storedTxtDisplay.BackColor = SettingsManager.instance.backColor;
            txtDisplay.BackColor = SettingsManager.instance.backColor;
            storedTxtDisplay.ForeColor = SettingsManager.instance.backFontColor;
            txtDisplay.ForeColor = SettingsManager.instance.backFontColor;
            foreach(Button btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = SettingsManager.instance.controlsColor;
                btn.ForeColor = SettingsManager.instance.controlsFontColor;
            }
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            second_number = 0;
            operation = "";
            storedTxtDisplay.Text = "0";
        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            if (last_operation != "=")
                btnEquals_Click(sender, e);

            txtDisplay.Text = "";
            last_operation = operation;

            if(last_operation != "=")
                storedTxtDisplay.Text = stored_number.ToString() + operation;
            else
                storedTxtDisplay.Text = stored_number.ToString() + "  " + operation + "  " + second_number.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (last_operation != "=")
                    second_number = double.Parse(txtDisplay.Text);

                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = Convert.ToString(stored_number + second_number);
                        break;
                    case "-":
                        txtDisplay.Text = Convert.ToString(stored_number - second_number);
                        break;
                    case "*":
                        txtDisplay.Text = Convert.ToString(stored_number * second_number);
                        break;
                    case "/":
                        txtDisplay.Text = Convert.ToString(stored_number / second_number);
                        break;
                    default:
                        return;
                }
                storedTxtDisplay.Text = stored_number.ToString() + "  " + operation + "  " + second_number.ToString();
                stored_number = double.Parse(txtDisplay.Text);
                last_operation = "=";
            }
        }
    }
}
