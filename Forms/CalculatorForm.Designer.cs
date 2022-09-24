namespace UtilitySharp.Forms
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.storedTxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 41);
            this.txtDisplay.MaxLength = 32;
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(334, 44);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnDel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(13, 91);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(79, 60);
            this.btnDel.TabIndex = 1;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnCE.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(98, 91);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(79, 60);
            this.btnCE.TabIndex = 2;
            this.btnCE.TabStop = false;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnC.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(183, 91);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(79, 60);
            this.btnC.TabIndex = 3;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnPow.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.ForeColor = System.Drawing.Color.White;
            this.btnPow.Location = new System.Drawing.Point(268, 91);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(79, 60);
            this.btnPow.TabIndex = 4;
            this.btnPow.TabStop = false;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(13, 157);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 60);
            this.btn1.TabIndex = 5;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(98, 157);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 60);
            this.btn2.TabIndex = 6;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(183, 157);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 60);
            this.btn3.TabIndex = 7;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnP.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.White;
            this.btnP.Location = new System.Drawing.Point(268, 157);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(79, 60);
            this.btnP.TabIndex = 8;
            this.btnP.TabStop = false;
            this.btnP.Text = "+";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn4.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(13, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 60);
            this.btn4.TabIndex = 9;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn5.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(98, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 60);
            this.btn5.TabIndex = 10;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn6.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(183, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 60);
            this.btn6.TabIndex = 11;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnM.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.Location = new System.Drawing.Point(268, 223);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(79, 60);
            this.btnM.TabIndex = 12;
            this.btnM.TabStop = false;
            this.btnM.Text = "-";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn7.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(13, 289);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 60);
            this.btn7.TabIndex = 13;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn8.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(98, 289);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 60);
            this.btn8.TabIndex = 14;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn9.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(183, 289);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 60);
            this.btn9.TabIndex = 15;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnMult.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(268, 289);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(79, 60);
            this.btnMult.TabIndex = 16;
            this.btnMult.TabStop = false;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btn0.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(13, 355);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 60);
            this.btn0.TabIndex = 17;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnDot.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(98, 355);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(79, 60);
            this.btnDot.TabIndex = 18;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnEquals.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(183, 355);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(79, 60);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.btnDiv.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(268, 355);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(79, 60);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.Operational_Function);
            // 
            // storedTxtDisplay
            // 
            this.storedTxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storedTxtDisplay.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storedTxtDisplay.Location = new System.Drawing.Point(12, 12);
            this.storedTxtDisplay.Multiline = true;
            this.storedTxtDisplay.Name = "storedTxtDisplay";
            this.storedTxtDisplay.ReadOnly = true;
            this.storedTxtDisplay.Size = new System.Drawing.Size(334, 21);
            this.storedTxtDisplay.TabIndex = 23;
            this.storedTxtDisplay.TabStop = false;
            this.storedTxtDisplay.Text = "0";
            this.storedTxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 431);
            this.Controls.Add(this.storedTxtDisplay);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox storedTxtDisplay;
    }
}