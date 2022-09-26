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
            this.timeDisplay = new System.Windows.Forms.TextBox();
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stopwatch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stopwatchBtn_Click);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(137, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Countdown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.countdownBtn_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.functionsPanel);
            this.Controls.Add(this.liveHourPanel);
            this.Name = "TimerForm";
            this.Text = "TimerForm";
            this.liveHourPanel.ResumeLayout(false);
            this.liveHourPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel liveHourPanel;
        private System.Windows.Forms.TextBox timeDisplay;
        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}