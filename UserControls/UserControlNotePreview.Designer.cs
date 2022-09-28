namespace UtilitySharp.UserControls
{
    partial class UserControlNotePreview
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
            this.lbNoteTitle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.noteDelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNoteTitle
            // 
            this.lbNoteTitle.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoteTitle.Location = new System.Drawing.Point(9, 5);
            this.lbNoteTitle.Name = "lbNoteTitle";
            this.lbNoteTitle.Size = new System.Drawing.Size(413, 23);
            this.lbNoteTitle.TabIndex = 0;
            this.lbNoteTitle.Text = "Title";
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.Location = new System.Drawing.Point(10, 28);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(600, 23);
            this.lbContent.TabIndex = 1;
            this.lbContent.Text = "Title";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(616, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(56, 31);
            this.openBtn.TabIndex = 2;
            this.openBtn.TabStop = false;
            this.openBtn.Text = "OP";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.noteOpenBtn_Click);
            // 
            // noteDelBtn
            // 
            this.noteDelBtn.Location = new System.Drawing.Point(678, 12);
            this.noteDelBtn.Name = "noteDelBtn";
            this.noteDelBtn.Size = new System.Drawing.Size(56, 31);
            this.noteDelBtn.TabIndex = 3;
            this.noteDelBtn.TabStop = false;
            this.noteDelBtn.Text = "DEL";
            this.noteDelBtn.UseVisualStyleBackColor = true;
            this.noteDelBtn.Click += new System.EventHandler(this.noteDelBtn_Click);
            // 
            // UserControlNotePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteDelBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbNoteTitle);
            this.Name = "UserControlNotePreview";
            this.Size = new System.Drawing.Size(750, 60);
            this.Load += new System.EventHandler(this.UserControlNotePreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label lbNoteTitle;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Button noteDelBtn;
    }
}
