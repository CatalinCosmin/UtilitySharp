using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Drawing;
using UtilitySharp.UserControls;
using UtilitySharp.Forms;

namespace UtilitySharp.Entities
{
    public class SettingsManager
    {
        public static SettingsManager instance;

        public bool runOnStartup;
        public bool systemTray;

        public Color controlsColor;
        public Color highlightedControlsColor;
        public Color backColor;
        public Color controlsFontColor;
        public Color backFontColor;

        public SettingsManager()
        {
            instance = this;

            InitFromCfg();
        }

        public void InitFromCfg()
        {
            runOnStartup = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("Startup"));
            systemTray = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("SystemTray"));

            // Controls color
            string[] color1 = ConfigurationManager.AppSettings.Get("Color").Split();
            var color1ints = color1.Select(item => int.Parse(item)).ToArray();
            controlsColor = Color.FromArgb(255, color1ints[0], color1ints[1], color1ints[2]);

            // Highlighted controls color
            string[] color2 = ConfigurationManager.AppSettings.Get("HighlightedColor").Split();
            var color2ints = color2.Select(item => int.Parse(item)).ToArray();
            highlightedControlsColor = Color.FromArgb(255, color2ints[0], color2ints[1], color2ints[2]);

            // Background color
            string[] color3 = ConfigurationManager.AppSettings.Get("BackColor").Split();
            var color3ints = color3.Select(item => int.Parse(item)).ToArray();
            backColor = Color.FromArgb(255, color3ints[0], color3ints[1], color3ints[2]);

            // Background color
            string[] color4 = ConfigurationManager.AppSettings.Get("ControlFontColor").Split();
            var color4ints = color4.Select(item => int.Parse(item)).ToArray();
            controlsFontColor = Color.FromArgb(255, color4ints[0], color4ints[1], color4ints[2]);

            // Background color
            string[] color5 = ConfigurationManager.AppSettings.Get("BackFontColor").Split();
            var color5ints = color5.Select(item => int.Parse(item)).ToArray();
            backFontColor = Color.FromArgb(255, color5ints[0], color5ints[1], color5ints[2]);
        }

        public void OnSave()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configFile.AppSettings.Settings["Color"].Value = SettingsForm.controlsColor.R + " " + SettingsForm.controlsColor.G + " " + SettingsForm.controlsColor.B;
            configFile.AppSettings.Settings["ControlFontColor"].Value = SettingsForm.controlsFontColor.R + " " + SettingsForm.controlsFontColor.G + " " + SettingsForm.controlsFontColor.B;
            configFile.AppSettings.Settings["BackColor"].Value = SettingsForm.backColor.R + " " + SettingsForm.backColor.G + " " + SettingsForm.backColor.B;
            configFile.AppSettings.Settings["BackFontColor"].Value = SettingsForm.backFontColor.R + " " + SettingsForm.backFontColor.G + " " + SettingsForm.backFontColor.B;
            configFile.AppSettings.Settings["HighlightedColor"].Value = SettingsForm.highlightedColor.R + " " + SettingsForm.highlightedColor.G + " " + SettingsForm.highlightedColor.B;


            configFile.AppSettings.Settings["Startup"].Value = SettingsForm.runOnStartup.ToString();
            configFile.AppSettings.Settings["SystemTray"].Value = SettingsForm.systemTray.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            SettingsManager.instance.InitFromCfg();

            Form1.instance.SetStartup();
        }
    }
}
