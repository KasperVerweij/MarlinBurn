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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.Location = new System.Drawing.Point(376, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 451);
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
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 689);
            this.textBox1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 800);
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
            this.DpiTb.Text = "12";
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
            this.NozzOffsY.Text = "24";
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
            this.HomeZCheckBox.Checked = true;
            this.HomeZCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.MaterialThicknessTb.Text = "20";
            this.MaterialThicknessTb.TextChanged += new System.EventHandler(this.MaterialThicknessTb_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 608);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(357, 215);
            this.textBox2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 835);
            this.Controls.Add(this.textBox2);
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
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox textBox2;
    }
}

