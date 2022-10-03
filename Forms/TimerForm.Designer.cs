namespace UtilitySharp.Forms
{
    partial class TimerForm
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
            this.liveHourPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timeDisplay = new System.Windows.Forms.TextBox();
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.stopwatchBtn = new System.Windows.Forms.Button();
            this.countdownBtn = new System.Windows.Forms.Button();
            this.liveHourPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // liveHourPanel
            // 
            this.liveHourPanel.Controls.Add(this.textBox1);
            this.liveHourPanel.Controls.Add(this.timeDisplay);
            this.liveHourPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.liveHourPanel.Location = new System.Drawing.Point(0, 0);
            this.liveHourPanel.Name = "liveHourPanel";
            this.liveHourPanel.Size = new System.Drawing.Size(800, 82);
            this.liveHourPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Current Date";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeDisplay
            // 
            this.timeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeDisplay.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.Location = new System.Drawing.Point(258, 12);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.ReadOnly = true;
            this.timeDisplay.Size = new System.Drawing.Size(304, 37);
            this.timeDisplay.TabIndex = 1;
            this.timeDisplay.TabStop = false;
            this.timeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // functionsPanel
            // 
            this.functionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.functionsPanel.Location = new System.Drawing.Point(0, 122);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.Size = new System.Drawing.Size(800, 328);
            this.functionsPanel.TabIndex = 1;
            // 
            // stopwatchBtn
            // 
            this.stopwatchBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchBtn.Location = new System.Drawing.Point(29, 88);
            this.stopwatchBtn.Name = "stopwatchBtn";
            this.stopwatchBtn.Size = new System.Drawing.Size(115, 28);
            this.stopwatchBtn.TabIndex = 2;
            this.stopwatchBtn.Text = "Stopwatch";
            this.stopwatchBtn.UseVisualStyleBackColor = true;
            this.stopwatchBtn.Click += new System.EventHandler(this.stopwatchBtn_Click);
            // 
            // countdownBtn
            // 
            this.countdownBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownBtn.Location = new System.Drawing.Point(166, 88);
            this.countdownBtn.Name = "countdownBtn";
            this.countdownBtn.Size = new System.Drawing.Size(115, 28);
            this.countdownBtn.TabIndex = 3;
            this.countdownBtn.Text = "Countdown";
            this.countdownBtn.UseVisualStyleBackColor = true;
            this.countdownBtn.Click += new System.EventHandler(this.countdownBtn_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countdownBtn);
            this.Controls.Add(this.stopwatchBtn);
            this.Controls.Add(this.functionsPanel);
            this.Controls.Add(this.liveHourPanel);
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            this.liveHourPanel.ResumeLayout(false);
            this.liveHourPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel liveHourPanel;
        private System.Windows.Forms.TextBox timeDisplay;
        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button stopwatchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button countdownBtn;
    }
}