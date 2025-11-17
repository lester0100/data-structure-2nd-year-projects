
namespace Coding_Challenge_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDisplay.Location = new System.Drawing.Point(178, 155);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 31);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.WindowText;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(100, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 24);
            this.label18.TabIndex = 26;
            this.label18.Text = "Linear Search Simulator";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtGrade.Enabled = false;
            this.txtGrade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGrade.Location = new System.Drawing.Point(237, 140);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(63, 26);
            this.txtGrade.TabIndex = 27;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrade.Visible = false;
            this.txtGrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrade_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.Location = new System.Drawing.Point(59, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.ReadOnly = true;
            this.lblResult.Size = new System.Drawing.Size(300, 26);
            this.lblResult.TabIndex = 28;
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblResult.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(47, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 64);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            this.groupBox1.Visible = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrade.Location = new System.Drawing.Point(126, 143);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(105, 19);
            this.lblGrade.TabIndex = 25;
            this.lblGrade.Text = "Enter a grade:";
            this.lblGrade.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.WindowText;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(371, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 6;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(218, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(167, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(65, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(116, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(269, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.WindowText;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(320, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 7;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.WindowText;
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            this.label27.Location = new System.Drawing.Point(320, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 19);
            this.label27.TabIndex = 37;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Visible = false;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.WindowText;
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Location = new System.Drawing.Point(269, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 19);
            this.label26.TabIndex = 34;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Visible = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.WindowText;
            this.label23.ForeColor = System.Drawing.SystemColors.Window;
            this.label23.Location = new System.Drawing.Point(116, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 19);
            this.label23.TabIndex = 33;
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Visible = false;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.WindowText;
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(65, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 19);
            this.label22.TabIndex = 30;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.WindowText;
            this.label21.ForeColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(14, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 19);
            this.label21.TabIndex = 31;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Visible = false;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.WindowText;
            this.label24.ForeColor = System.Drawing.SystemColors.Window;
            this.label24.Location = new System.Drawing.Point(167, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 19);
            this.label24.TabIndex = 32;
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Visible = false;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.WindowText;
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            this.label25.Location = new System.Drawing.Point(218, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 19);
            this.label25.TabIndex = 35;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Visible = false;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.WindowText;
            this.label28.ForeColor = System.Drawing.SystemColors.Window;
            this.label28.Location = new System.Drawing.Point(371, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 19);
            this.label28.TabIndex = 36;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRetry.Enabled = false;
            this.btnRetry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetry.Location = new System.Drawing.Point(178, 250);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 31);
            this.btnRetry.TabIndex = 38;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(426, 288);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label28);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRetry;
    }
}

