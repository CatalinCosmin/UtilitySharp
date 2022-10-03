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
            this.settingsBtn = new System.Windows.Forms.Button();
            this.todoBtn = new System.Windows.Forms.Button();
            this.notesBtn = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.cldnBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Controls.Add(this.todoBtn);
            this.panel1.Controls.Add(this.notesBtn);
            this.panel1.Controls.Add(this.timerBtn);
            this.panel1.Controls.Add(this.cldnBtn);
            this.panel1.Controls.Add(this.calcBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 88);
            this.panel1.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.settings_icon_default;
            this.settingsBtn.Location = new System.Drawing.Point(412, 9);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(80, 74);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // todoBtn
            // 
            this.todoBtn.AutoSize = true;
            this.todoBtn.BackColor = System.Drawing.Color.Transparent;
            this.todoBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.todo_icon_default;
            this.todoBtn.Location = new System.Drawing.Point(332, 9);
            this.todoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(80, 74);
            this.todoBtn.TabIndex = 4;
            this.todoBtn.TabStop = false;
            this.todoBtn.UseVisualStyleBackColor = false;
            this.todoBtn.Click += new System.EventHandler(this.todoBtn_Click);
            // 
            // notesBtn
            // 
            this.notesBtn.AutoSize = true;
            this.notesBtn.BackColor = System.Drawing.Color.Transparent;
            this.notesBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.notes_icon_default;
            this.notesBtn.Location = new System.Drawing.Point(252, 9);
            this.notesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.Size = new System.Drawing.Size(80, 74);
            this.notesBtn.TabIndex = 3;
            this.notesBtn.TabStop = false;
            this.notesBtn.UseVisualStyleBackColor = false;
            this.notesBtn.Click += new System.EventHandler(this.notesBtn_Click);
            // 
            // timerBtn
            // 
            this.timerBtn.AutoSize = true;
            this.timerBtn.BackColor = System.Drawing.Color.Transparent;
            this.timerBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.timer_icon_default;
            this.timerBtn.Location = new System.Drawing.Point(172, 9);
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
            this.cldnBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.calendar_icon_default;
            this.cldnBtn.Location = new System.Drawing.Point(92, 9);
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
            this.calcBtn.BackgroundImage = global::UtilitySharp.Properties.Resources.calc_icon_default;
            this.calcBtn.Location = new System.Drawing.Point(12, 9);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(80, 74);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.TabStop = false;
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Text = "notifyIcon1";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systemTrayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 76);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.toDoListToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.toDoListToolStripMenuItem.Text = "To do list";
            this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 88);
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
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button todoBtn;
        private System.Windows.Forms.Button notesBtn;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.Button cldnBtn;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
    }
}

