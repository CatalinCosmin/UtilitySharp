namespace UtilitySharp.UserControls
{
    partial class UserControlDays
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
            this.backPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.daysText = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.daysText);
            this.backPanel.Location = new System.Drawing.Point(3, 3);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(119, 94);
            this.backPanel.TabIndex = 0;
            this.backPanel.Click += new System.EventHandler(this.AddEvent);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "has events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysText
            // 
            this.daysText.BackColor = System.Drawing.Color.Transparent;
            this.daysText.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysText.ForeColor = System.Drawing.Color.White;
            this.daysText.Location = new System.Drawing.Point(3, 7);
            this.daysText.Name = "daysText";
            this.daysText.Size = new System.Drawing.Size(39, 25);
            this.daysText.TabIndex = 3;
            this.daysText.Text = "XX";
            this.daysText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.backPanel);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(125, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.AddEvent);
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daysText;
    }
}
