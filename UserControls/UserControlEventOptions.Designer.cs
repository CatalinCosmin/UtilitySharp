﻿namespace UtilitySharp.UserControls
{
    partial class UserControlEventOptions
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(3, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(631, 70);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "Prima picare de sesiune a lui stan david florin";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(651, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(47, 43);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "MOD";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(704, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 43);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "REM";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // UserControlEventOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbDescription);
            this.Name = "UserControlEventOptions";
            this.Size = new System.Drawing.Size(760, 70);
            this.Load += new System.EventHandler(this.UserControlEventOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
    }
}