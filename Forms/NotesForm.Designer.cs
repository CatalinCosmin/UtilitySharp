namespace UtilitySharp.Forms
{
    partial class NotesForm
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
            this.notesListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesListPanel
            // 
            this.notesListPanel.AutoScroll = true;
            this.notesListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesListPanel.Location = new System.Drawing.Point(0, 0);
            this.notesListPanel.Name = "notesListPanel";
            this.notesListPanel.Size = new System.Drawing.Size(800, 261);
            this.notesListPanel.TabIndex = 0;
            this.notesListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Location = new System.Drawing.Point(682, 267);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(106, 31);
            this.addNoteBtn.TabIndex = 1;
            this.addNoteBtn.Text = "Add";
            this.addNoteBtn.UseVisualStyleBackColor = true;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.addNoteBtn);
            this.Controls.Add(this.notesListPanel);
            this.Name = "NotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notesListPanel;
        private System.Windows.Forms.Button addNoteBtn;
    }
}