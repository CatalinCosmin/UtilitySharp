namespace UtilitySharp.Forms
{
    partial class NotePreviewForm
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
            this.titleDisplay = new System.Windows.Forms.RichTextBox();
            this.contentDisplay = new System.Windows.Forms.RichTextBox();
            this.saveTitleBtn = new System.Windows.Forms.Button();
            this.saveContentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleDisplay
            // 
            this.titleDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.titleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleDisplay.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDisplay.Location = new System.Drawing.Point(27, 32);
            this.titleDisplay.Multiline = false;
            this.titleDisplay.Name = "titleDisplay";
            this.titleDisplay.Size = new System.Drawing.Size(441, 45);
            this.titleDisplay.TabIndex = 2;
            this.titleDisplay.TabStop = false;
            this.titleDisplay.Text = "Title";
            this.titleDisplay.TextChanged += new System.EventHandler(this.titleDisplay_TextChanged);
            // 
            // contentDisplay
            // 
            this.contentDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentDisplay.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentDisplay.Location = new System.Drawing.Point(27, 83);
            this.contentDisplay.Name = "contentDisplay";
            this.contentDisplay.Size = new System.Drawing.Size(748, 296);
            this.contentDisplay.TabIndex = 3;
            this.contentDisplay.TabStop = false;
            this.contentDisplay.Text = "Content";
            this.contentDisplay.TextChanged += new System.EventHandler(this.contentDisplay_TextChanged);
            // 
            // saveTitleBtn
            // 
            this.saveTitleBtn.Location = new System.Drawing.Point(474, 32);
            this.saveTitleBtn.Name = "saveTitleBtn";
            this.saveTitleBtn.Size = new System.Drawing.Size(48, 45);
            this.saveTitleBtn.TabIndex = 4;
            this.saveTitleBtn.Text = "Save";
            this.saveTitleBtn.UseVisualStyleBackColor = true;
            this.saveTitleBtn.Click += new System.EventHandler(this.saveTitleBtn_Click);
            // 
            // saveContentBtn
            // 
            this.saveContentBtn.Location = new System.Drawing.Point(27, 385);
            this.saveContentBtn.Name = "saveContentBtn";
            this.saveContentBtn.Size = new System.Drawing.Size(48, 45);
            this.saveContentBtn.TabIndex = 5;
            this.saveContentBtn.Text = "Save";
            this.saveContentBtn.UseVisualStyleBackColor = true;
            this.saveContentBtn.Click += new System.EventHandler(this.saveContentBtn_Click);
            // 
            // NotePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveContentBtn);
            this.Controls.Add(this.saveTitleBtn);
            this.Controls.Add(this.contentDisplay);
            this.Controls.Add(this.titleDisplay);
            this.Name = "NotePreviewForm";
            this.Text = "NotePreviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            this.Load += new System.EventHandler(this.NotePreviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox titleDisplay;
        private System.Windows.Forms.RichTextBox contentDisplay;
        private System.Windows.Forms.Button saveTitleBtn;
        private System.Windows.Forms.Button saveContentBtn;
    }
}