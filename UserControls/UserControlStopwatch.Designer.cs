namespace UtilitySharp.UserControls
{
    partial class UserControlStopwatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeDisplay = new System.Windows.Forms.MaskedTextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.lapBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.lapsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeDisplay
            // 
            this.timeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeDisplay.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.Location = new System.Drawing.Point(274, 51);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.ReadOnly = true;
            this.timeDisplay.Size = new System.Drawing.Size(250, 46);
            this.timeDisplay.TabIndex = 1;
            this.timeDisplay.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(98, 124);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(152, 46);
            this.startBtn.TabIndex = 2;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // lapBtn
            // 
            this.lapBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapBtn.Location = new System.Drawing.Point(319, 124);
            this.lapBtn.Name = "lapBtn";
            this.lapBtn.Size = new System.Drawing.Size(152, 46);
            this.lapBtn.TabIndex = 3;
            this.lapBtn.TabStop = false;
            this.lapBtn.Text = "Lap";
            this.lapBtn.UseVisualStyleBackColor = true;
            this.lapBtn.Click += new System.EventHandler(this.lapBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Location = new System.Drawing.Point(539, 124);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(152, 46);
            this.pauseBtn.TabIndex = 4;
            this.pauseBtn.TabStop = false;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // lapsPanel
            // 
            this.lapsPanel.AutoScroll = true;
            this.lapsPanel.Location = new System.Drawing.Point(98, 175);
            this.lapsPanel.Name = "lapsPanel";
            this.lapsPanel.Size = new System.Drawing.Size(223, 138);
            this.lapsPanel.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(346, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 41);
            this.button4.TabIndex = 6;
            this.button4.TabStop = false;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // UserControlStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lapsPanel);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.lapBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeDisplay);
            this.Name = "UserControlStopwatch";
            this.Size = new System.Drawing.Size(800, 328);
            this.Load += new System.EventHandler(this.UserControlStopwatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox timeDisplay;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button lapBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.FlowLayoutPanel lapsPanel;
        private System.Windows.Forms.Button button4;
    }
}
