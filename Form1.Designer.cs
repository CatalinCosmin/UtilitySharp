namespace UtilitySharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.cldnBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.timerBtn);
            this.panel1.Controls.Add(this.cldnBtn);
            this.panel1.Controls.Add(this.calcBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 174);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::UtilitySharp.Properties.Resources.settings_icon;
            this.button7.Location = new System.Drawing.Point(492, 14);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 74);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.button6.BackgroundImage = global::UtilitySharp.Properties.Resources.shortcuts_icon;
            this.button6.Location = new System.Drawing.Point(412, 14);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 74);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::UtilitySharp.Properties.Resources.todo_icon;
            this.button5.Location = new System.Drawing.Point(332, 14);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 74);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::UtilitySharp.Properties.Resources.notes_icon;
            this.button4.Location = new System.Drawing.Point(252, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 74);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timerBtn
            // 
            this.timerBtn.AutoSize = true;
            this.timerBtn.BackColor = System.Drawing.Color.Transparent;
            this.timerBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.timer_icon;
            this.timerBtn.Location = new System.Drawing.Point(172, 12);
            this.timerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(80, 74);
            this.timerBtn.TabIndex = 2;
            this.timerBtn.TabStop = false;
            this.timerBtn.UseVisualStyleBackColor = false;
            this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
            // 
            // cldnBtn
            // 
            this.cldnBtn.AutoSize = true;
            this.cldnBtn.BackColor = System.Drawing.Color.Transparent;
            this.cldnBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.calendar_icon;
            this.cldnBtn.Location = new System.Drawing.Point(92, 12);
            this.cldnBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cldnBtn.Name = "cldnBtn";
            this.cldnBtn.Size = new System.Drawing.Size(80, 74);
            this.cldnBtn.TabIndex = 1;
            this.cldnBtn.TabStop = false;
            this.cldnBtn.UseVisualStyleBackColor = false;
            this.cldnBtn.Click += new System.EventHandler(this.cldnBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.AutoSize = true;
            this.calcBtn.BackColor = System.Drawing.Color.Transparent;
            this.calcBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.calc_icon;
            this.calcBtn.Location = new System.Drawing.Point(12, 12);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(80, 74);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.TabStop = false;
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.toDoListToolStripMenuItem,
            this.shortcutsToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notesToolStripMenuItem.Text = "Notes";
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toDoListToolStripMenuItem.Text = "To do list";
            this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shortcutsToolStripMenuItem.Text = "Web Shortcuts";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 174);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.Button cldnBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

