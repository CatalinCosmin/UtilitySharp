using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using UtilitySharp.Entities;
using UtilitySharp.UserControls;
using Color = System.Drawing.Color;

namespace UtilitySharp.Forms
{
    public partial class SettingsForm : Form
    {
        public static SettingsForm instance;
        public static bool runOnStartup;
        public static bool systemTray;
        public static Color controlsColor;
        public static Color controlsFontColor;
        public static Color backColor;
        public static Color backFontColor;
        public static Color highlightedColor;
        public SettingsForm()
        {
            instance = this;
            InitializeComponent();
            InitColorPreview();
            InitColors();
            InitSettings();
        }

        private void InitSettings()
        {
            SettingsManager stinst = SettingsManager.instance;

            runOnStartup = stinst.runOnStartup;
            systemTray = stinst.systemTray;
            controlsColor = stinst.controlsColor;
            controlsFontColor = stinst.controlsFontColor;
            backColor = stinst.backColor;
            backFontColor = stinst.backFontColor;
            highlightedColor = stinst.highlightedControlsColor;

            checkBox1.Checked = runOnStartup;
            checkBox2.Checked = systemTray;
        }

        private void InitColors()
        {
            SettingsManager stinst = SettingsManager.instance;

            this.BackColor = stinst.backColor;

            label1.BackColor = Color.Transparent;
            label1.ForeColor = stinst.backFontColor;

            label2.BackColor = Color.Transparent;
            label2.ForeColor = stinst.backFontColor;

            checkBox1.BackColor = stinst.controlsColor;
            checkBox2.BackColor = stinst.controlsColor;

            flowLayoutPanel1.BackColor = stinst.backColor;

            button1.BackColor = stinst.controlsColor;
            button1.ForeColor = stinst.controlsFontColor;

            button2.BackColor = stinst.controlsColor;
            button2.ForeColor = stinst.controlsFontColor;

            button3.BackColor = stinst.controlsColor;
            button3.ForeColor = stinst.controlsFontColor;

            button4.BackColor = stinst.controlsColor;
            button4.ForeColor = stinst.controlsFontColor;

            button5.BackColor = stinst.controlsColor;
            button5.ForeColor = stinst.controlsFontColor;

            settingsPanel.BackColor = stinst.backColor;

            saveBtn.BackColor = stinst.controlsColor;
            saveBtn.ForeColor = stinst.controlsFontColor;
        }

        private void InitColorPreview()
        {
            previewControlBtn.BackColor = SettingsManager.instance.controlsColor;
            previewHighlightedBtn.BackColor = SettingsManager.instance.highlightedControlsColor;
            previewPanel.BackColor = SettingsManager.instance.backColor;
            previewControlBtn.ForeColor = SettingsManager.instance.controlsFontColor;
            previewHighlightedBtn.ForeColor = SettingsManager.instance.controlsFontColor;
            lbPreviewBackgroundFont.ForeColor = SettingsManager.instance.backFontColor;

            saveBtn.BackColor = SettingsManager.instance.controlsColor;
            saveBtn.ForeColor = SettingsManager.instance.controlsFontColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPanel.Controls.Clear();
            UserControlColorPicker uccpicker = new UserControlColorPicker("Color");
            settingsPanel.Controls.Add(uccpicker);
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingsPanel.Controls.Clear();
            UserControlColorPicker uccpicker = new UserControlColorPicker("HighlightedColor");
            settingsPanel.Controls.Add(uccpicker);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settingsPanel.Controls.Clear();
            UserControlColorPicker uccpicker = new UserControlColorPicker("BackColor");
            settingsPanel.Controls.Add(uccpicker);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settingsPanel.Controls.Clear();
            UserControlColorPicker uccpicker = new UserControlColorPicker("ControlFontColor");
            settingsPanel.Controls.Add(uccpicker);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            settingsPanel.Controls.Clear();
            UserControlColorPicker uccpicker = new UserControlColorPicker("BackFontColor");
            settingsPanel.Controls.Add(uccpicker);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateColorsPreview(Color color, string value)
        {
            switch(value)
            {
                case "Color":
                    previewControlBtn.BackColor = color;
                    break;
                case "HighlightedColor":
                    previewHighlightedBtn.BackColor = color;
                    break;
                case "BackColor":
                    previewPanel.BackColor = color;
                    break;
                case "ControlFontColor":
                    previewControlBtn.ForeColor = color;
                    previewHighlightedBtn.ForeColor = color;
                    break;
                case "BackFontColor":
                    lbPreviewBackgroundFont.ForeColor = color;
                    break;
                default:
                    break;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            systemTray = checkBox2.Checked;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SettingsManager.instance.OnSave();
            InitSettings();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            runOnStartup = checkBox1.Checked;
        }
    }
}
