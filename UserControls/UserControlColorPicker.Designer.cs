namespace UtilitySharp.UserControls
{
    partial class UserControlColorPicker
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
            this.colorPreview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // colorPreview
            // 
            this.colorPreview.Location = new System.Drawing.Point(634, 0);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(76, 25);
            this.colorPreview.TabIndex = 0;
            this.colorPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPreview_Paint);
            // 
            // UserControlColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPreview);
            this.Name = "UserControlColorPicker";
            this.Size = new System.Drawing.Size(710, 200);
            this.Load += new System.EventHandler(this.UserControlColorPicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel colorPreview;
    }
}
