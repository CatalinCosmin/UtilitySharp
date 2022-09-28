namespace UtilitySharp.UserControls
{
    partial class UserControlCountdown
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
            this.eventsDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eventsDropdown
            // 
            this.eventsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventsDropdown.FormattingEnabled = true;
            this.eventsDropdown.Location = new System.Drawing.Point(39, 60);
            this.eventsDropdown.Name = "eventsDropdown";
            this.eventsDropdown.Size = new System.Drawing.Size(263, 24);
            this.eventsDropdown.TabIndex = 0;
            this.eventsDropdown.SelectedIndexChanged += new System.EventHandler(this.eventsDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the event";
            // 
            // timeDisplay
            // 
            this.timeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeDisplay.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.Location = new System.Drawing.Point(409, 60);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.ReadOnly = true;
            this.timeDisplay.Size = new System.Drawing.Size(339, 37);
            this.timeDisplay.TabIndex = 2;
            this.timeDisplay.TabStop = false;
            // 
            // UserControlCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventsDropdown);
            this.Name = "UserControlCountdown";
            this.Size = new System.Drawing.Size(800, 328);
            this.Load += new System.EventHandler(this.UserControlCountdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eventsDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeDisplay;
    }
}
