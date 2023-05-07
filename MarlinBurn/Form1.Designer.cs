namespace MarlinBurn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.XSizeTb = new System.Windows.Forms.TextBox();
            this.YSixeTb = new System.Windows.Forms.TextBox();
            this.DpiTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NozzOffsY = new System.Windows.Forms.TextBox();
            this.NozzleOffsX = new System.Windows.Forms.TextBox();
            this.HomeZCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaterialThicknessTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InvertEngrave = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EngravePowerTb = new System.Windows.Forms.TextBox();
            this.MaxDiodePowerTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TimeRemainingTb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1107, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.Connect);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(114, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 28);
            this.panel3.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(200, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(352, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 7;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(65, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Barf Marlin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1148, 802);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Export Gcode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // XSizeTb
            // 
            this.XSizeTb.Location = new System.Drawing.Point(179, 49);
            this.XSizeTb.Name = "XSizeTb";
            this.XSizeTb.Size = new System.Drawing.Size(100, 20);
            this.XSizeTb.TabIndex = 12;
            this.XSizeTb.Text = "100";
            // 
            // YSixeTb
            // 
            this.YSixeTb.Location = new System.Drawing.Point(179, 75);
            this.YSixeTb.Name = "YSixeTb";
            this.YSixeTb.Size = new System.Drawing.Size(100, 20);
            this.YSixeTb.TabIndex = 13;
            this.YSixeTb.Text = "100";
            // 
            // DpiTb
            // 
            this.DpiTb.Location = new System.Drawing.Point(179, 101);
            this.DpiTb.Name = "DpiTb";
            this.DpiTb.Size = new System.Drawing.Size(100, 20);
            this.DpiTb.TabIndex = 14;
            this.DpiTb.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Width[mm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Height[mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "DPI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "NozzOffsY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "NozzOffsX";
            // 
            // NozzOffsY
            // 
            this.NozzOffsY.Location = new System.Drawing.Point(367, 75);
            this.NozzOffsY.Name = "NozzOffsY";
            this.NozzOffsY.Size = new System.Drawing.Size(100, 20);
            this.NozzOffsY.TabIndex = 19;
            this.NozzOffsY.Text = "50";
            this.NozzOffsY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NozzleOffsX
            // 
            this.NozzleOffsX.Location = new System.Drawing.Point(367, 49);
            this.NozzleOffsX.Name = "NozzleOffsX";
            this.NozzleOffsX.Size = new System.Drawing.Size(100, 20);
            this.NozzleOffsX.TabIndex = 18;
            this.NozzleOffsX.Text = "0";
            // 
            // HomeZCheckBox
            // 
            this.HomeZCheckBox.AutoSize = true;
            this.HomeZCheckBox.Location = new System.Drawing.Point(554, 51);
            this.HomeZCheckBox.Name = "HomeZCheckBox";
            this.HomeZCheckBox.Size = new System.Drawing.Size(64, 17);
            this.HomeZCheckBox.TabIndex = 22;
            this.HomeZCheckBox.Text = "Home Z";
            this.HomeZCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Material Thickness";
            // 
            // MaterialThicknessTb
            // 
            this.MaterialThicknessTb.Location = new System.Drawing.Point(631, 68);
            this.MaterialThicknessTb.Name = "MaterialThicknessTb";
            this.MaterialThicknessTb.Size = new System.Drawing.Size(100, 20);
            this.MaterialThicknessTb.TabIndex = 23;
            this.MaterialThicknessTb.Text = "0";
            this.MaterialThicknessTb.TextChanged += new System.EventHandler(this.MaterialThicknessTb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "label8";
            // 
            // InvertEngrave
            // 
            this.InvertEngrave.AutoSize = true;
            this.InvertEngrave.Location = new System.Drawing.Point(554, 101);
            this.InvertEngrave.Name = "InvertEngrave";
            this.InvertEngrave.Size = new System.Drawing.Size(53, 17);
            this.InvertEngrave.TabIndex = 27;
            this.InvertEngrave.Text = "Invert";
            this.InvertEngrave.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1148, 773);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Preview";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1148, 672);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(790, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Engrave Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Diode Power Limit";
            // 
            // EngravePowerTb
            // 
            this.EngravePowerTb.Location = new System.Drawing.Point(886, 78);
            this.EngravePowerTb.Name = "EngravePowerTb";
            this.EngravePowerTb.Size = new System.Drawing.Size(100, 20);
            this.EngravePowerTb.TabIndex = 31;
            this.EngravePowerTb.Text = "255";
            // 
            // MaxDiodePowerTb
            // 
            this.MaxDiodePowerTb.Location = new System.Drawing.Point(886, 52);
            this.MaxDiodePowerTb.Name = "MaxDiodePowerTb";
            this.MaxDiodePowerTb.Size = new System.Drawing.Size(100, 20);
            this.MaxDiodePowerTb.TabIndex = 30;
            this.MaxDiodePowerTb.Text = "255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(790, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Move Speed: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(992, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "255 = full diode, 100 mm / s";
            // 
            // TimeRemainingTb
            // 
            this.TimeRemainingTb.AutoSize = true;
            this.TimeRemainingTb.Location = new System.Drawing.Point(1156, 595);
            this.TimeRemainingTb.Name = "TimeRemainingTb";
            this.TimeRemainingTb.Size = new System.Drawing.Size(83, 13);
            this.TimeRemainingTb.TabIndex = 36;
            this.TimeRemainingTb.Text = "Time Remaining";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 837);
            this.Controls.Add(this.TimeRemainingTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EngravePowerTb);
            this.Controls.Add(this.MaxDiodePowerTb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InvertEngrave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaterialThicknessTb);
            this.Controls.Add(this.HomeZCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NozzOffsY);
            this.Controls.Add(this.NozzleOffsX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DpiTb);
            this.Controls.Add(this.YSixeTb);
            this.Controls.Add(this.XSizeTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox XSizeTb;
        private System.Windows.Forms.TextBox YSixeTb;
        private System.Windows.Forms.TextBox DpiTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NozzOffsY;
        private System.Windows.Forms.TextBox NozzleOffsX;
        private System.Windows.Forms.CheckBox HomeZCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaterialThicknessTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox InvertEngrave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EngravePowerTb;
        private System.Windows.Forms.TextBox MaxDiodePowerTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TimeRemainingTb;
    }
}

