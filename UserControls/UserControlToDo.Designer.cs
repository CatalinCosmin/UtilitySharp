namespace UtilitySharp.UserControls
{
    partial class UserControlToDo
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
            this.delBtn = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.modBtn = new System.Windows.Forms.Button();
            this.ToDoDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(545, 5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(32, 32);
            this.delBtn.TabIndex = 1;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "del";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // checkBox
            // 
            this.checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(472, 2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 37);
            this.checkBox.TabIndex = 2;
            this.checkBox.TabStop = false;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(507, 5);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(32, 32);
            this.modBtn.TabIndex = 3;
            this.modBtn.TabStop = false;
            this.modBtn.Text = "mod";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // ToDoDisplay
            // 
            this.ToDoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToDoDisplay.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoDisplay.Location = new System.Drawing.Point(23, 5);
            this.ToDoDisplay.Multiline = true;
            this.ToDoDisplay.Name = "ToDoDisplay";
            this.ToDoDisplay.Size = new System.Drawing.Size(427, 27);
            this.ToDoDisplay.TabIndex = 4;
            this.ToDoDisplay.TabStop = false;
            // 
            // UserControlToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToDoDisplay);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.delBtn);
            this.Name = "UserControlToDo";
            this.Size = new System.Drawing.Size(580, 40);
            this.Load += new System.EventHandler(this.UserControlToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.TextBox ToDoDisplay;
    }
}
