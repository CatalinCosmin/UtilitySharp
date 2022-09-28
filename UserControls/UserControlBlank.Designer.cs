namespace UtilitySharp.UserControls
{
    partial class UserControlBlank
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
            this.daysText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysText
            // 
            this.daysText.BackColor = System.Drawing.Color.Transparent;
            this.daysText.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysText.ForeColor = System.Drawing.Color.White;
            this.daysText.Location = new System.Drawing.Point(5, 5);
            this.daysText.Name = "daysText";
            this.daysText.Size = new System.Drawing.Size(39, 25);
            this.daysText.TabIndex = 2;
            this.daysText.Text = "XX";
            this.daysText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.daysText);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(125, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label daysText;
    }
}
