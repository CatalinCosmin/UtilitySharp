namespace UtilitySharp.Forms
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.previewHighlightedBtn = new System.Windows.Forms.Button();
            this.previewControlBtn = new System.Windows.Forms.Button();
            this.lbPreviewBackgroundFont = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open on Startup";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(262, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(262, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 23);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.TabStop = false;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimize to system tray";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 38);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 28);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Controls Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 28);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Highlight Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(277, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 28);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "Background";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(414, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 28);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "Controls Font";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(551, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 28);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "Background Font";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(12, 173);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(727, 214);
            this.settingsPanel.TabIndex = 5;
            // 
            // previewPanel
            // 
            this.previewPanel.Controls.Add(this.previewHighlightedBtn);
            this.previewPanel.Controls.Add(this.previewControlBtn);
            this.previewPanel.Controls.Add(this.lbPreviewBackgroundFont);
            this.previewPanel.Location = new System.Drawing.Point(760, 173);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(213, 214);
            this.previewPanel.TabIndex = 6;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // previewHighlightedBtn
            // 
            this.previewHighlightedBtn.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewHighlightedBtn.Location = new System.Drawing.Point(17, 165);
            this.previewHighlightedBtn.Name = "previewHighlightedBtn";
            this.previewHighlightedBtn.Size = new System.Drawing.Size(183, 39);
            this.previewHighlightedBtn.TabIndex = 2;
            this.previewHighlightedBtn.TabStop = false;
            this.previewHighlightedBtn.Text = "Highlighted Control";
            this.previewHighlightedBtn.UseVisualStyleBackColor = true;
            // 
            // previewControlBtn
            // 
            this.previewControlBtn.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewControlBtn.Location = new System.Drawing.Point(17, 120);
            this.previewControlBtn.Name = "previewControlBtn";
            this.previewControlBtn.Size = new System.Drawing.Size(183, 39);
            this.previewControlBtn.TabIndex = 1;
            this.previewControlBtn.TabStop = false;
            this.previewControlBtn.Text = "Preview Control Font";
            this.previewControlBtn.UseVisualStyleBackColor = true;
            // 
            // lbPreviewBackgroundFont
            // 
            this.lbPreviewBackgroundFont.AutoSize = true;
            this.lbPreviewBackgroundFont.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewBackgroundFont.Location = new System.Drawing.Point(13, 18);
            this.lbPreviewBackgroundFont.Name = "lbPreviewBackgroundFont";
            this.lbPreviewBackgroundFont.Size = new System.Drawing.Size(187, 21);
            this.lbPreviewBackgroundFont.TabIndex = 0;
            this.lbPreviewBackgroundFont.Text = "Preview Background Font";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(830, 26);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 48);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 437);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.previewPanel.ResumeLayout(false);
            this.previewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel settingsPanel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Button previewControlBtn;
        private System.Windows.Forms.Label lbPreviewBackgroundFont;
        private System.Windows.Forms.Button previewHighlightedBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}