using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.IO.IsolatedStorage;
using System.Data.SqlTypes;

namespace MarlinBurn
{
    public partial class Form1 : Form
    {
        int[] baudrates = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap Picture = new Bitmap(10, 10);

        double NozzleXOffset = 0;
        double NozzleYOffset = 0;
        int sendcounter = 0;
        int okcounter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog
            {
                ///DefaultExt = "BMP",
                InitialDirectory = "C:\\",
                //Filter = "RoboCell Sleeve Excel List (*.xlsx)|*.XLSX"
            };
            DialogResult resultpath = browser.ShowDialog();
            if (resultpath == DialogResult.OK)
            {

                Picture = (Bitmap)Image.FromFile(browser.FileName);
                pictureBox1.Image = Picture;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {

            if (serialPort1 == null) serialPort1 = new SerialPort();
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Connect.Text = "Connect";


            }
            else
            {
                serialPort1.BaudRate = (int)comboBox3.SelectedItem;
                serialPort1.PortName = comboBox2.Text;
                serialPort1.Open();
                Connect.Text = "Disconnect";


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            // Display each port name to the console.
            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
            }
            foreach (int i in baudrates)
            {
                comboBox3.Items.Add(i);
            }
            comboBox3.SelectedItem = baudrates[11];
            comboBox2.SelectedIndex = 0;
        }
        bool playing = false;
        private void button2_Click(object sender, EventArgs e)
        {
            playing = true;
            cansend = true;
        }
        string[] gcodemeuk = { "G90", "M3 S0","G0 X0 Y0 S0", "G0 X10 Y10 S0", "G0 X0 Y0 S10", "G0 X10 Y10 S10" };
        int index = 0;
        bool cansend = true;

        private void timer1_Tick(object sender, EventArgs e)
        {

            label8.Text = "sent: " + sendcounter + " received ok: " + okcounter; 
            if (playing)
            {

                if (sendcounter - okcounter < 5)
                {
                    cansend = false;
                    serialPort1.Write(gcodemeuk[index] + "\n");
                    sendcounter++;
                   // textBox1.Text += gcodemeuk[index]+ "\n";  
                    index++;
                    
                }

               
                if(index >= gcodemeuk.Length)
                { playing = false;
                    index = 0;
                }
            }        
        }
        string zwaffel = "hello\r\n";

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // is ok signal
            

            string ser = serialPort1.ReadLine();
           // zwaffel += ser; 
            if(ser.Contains("ok"))
            {
                okcounter++;
                cansend = true;

            }

            //else


        }
        string GCodeFeedRate(double frmms)
        {
            return GCode("G1 F" + (int)(frmms*60));
        }
        string GCodeLinMove(double x, double y, int power = 0)
        {
            x += NozzleXOffset;
            y += NozzleYOffset;

            x = System.Math.Round(x, 3);
               y = System.Math.Round(y, 3);

            return GCode("G1 X"+ GCodeFloat(x.ToString())  +" Y" + GCodeFloat(y.ToString()) + " S" + power);
        }
       string GCodeFloat(string inp)
        {
            return inp.Replace(',', '.');


        }
        string GCode(string inp)
        {
            return inp + "\r\n";
        }
        Bitmap outputBMP = new Bitmap(10, 10);
        private void button3_Click(object sender, EventArgs e)
        {
            engrave(true);
        }
        private void engrave(bool startengrave = false)
        {
            // export gcode

            double exportwidth = Double.Parse(XSizeTb.Text);
            double exportheight = Double.Parse(YSixeTb.Text);
            double pixeldense = Double.Parse(DpiTb.Text);
            bool HomeZ = HomeZCheckBox.Checked;
            double MaterialThickness = Double.Parse(MaterialThicknessTb.Text);
            NozzleXOffset = Double.Parse(NozzleOffsX.Text);
            NozzleYOffset = Double.Parse(NozzOffsY.Text);
            int MaxDiodePower = int.Parse(MaxDiodePowerTb.Text);
            double EngravingPower = double.Parse(EngravePowerTb.Text);





            string gcode = GCode("G28 X Y" + (HomeZ ? " Z" : ""));


            double feedrate = 15;

            gcode += GCode("G90"); // absolute positioning
            if (HomeZ)
            {
                gcode += GCode("G0 Z" + GCodeFloat(MaterialThickness.ToString())); // Move up by how thick material is
            }
            gcode += GCode("M3I");

            gcode += GCodeFeedRate(100);
            gcode += GCode("M220 S100");

            // initial square


            // this takes 25 seconds
            // should be 40  with a feedrate of 100mm/s
            // so what gives??
           //for (int i = 0; i < 10; i++)
          //  {


                gcode += GCodeLinMove(0, 0);
                gcode += GCodeLinMove(exportwidth, 0);
                gcode += GCodeLinMove(exportwidth, exportheight);
                gcode += GCodeLinMove(0, exportheight);
            // }
            // 4s in theory, starting from 0,0




            //int commandspersecond = pixeldense in mm * speed (mm per s)
            // 300 DPI
            // 100 commands per second I think is max
            // 300 DPI == 11 dots per mm
            // 100 mm/s * 11 dots = 1100 commands per second
            // 10 mm/s = 110 commandds per sec
            // 5 mm/s = 55 commands per sec
            // it seems to handle 15, a whopping 55*3 = 165 commands / second
            // every command = G0 X1000 Y1000 /r/n about 17 bytes
            // so around 2800 bytes per second
            // 22440 bits per second
            // 

            // DPI    FR
            // 300    15
            // 200    22,5                  
            // 100    45               // 4 pix per mm
            // 75     60 mm per sec    // 3 pix per mm
            gcode += GCodeFeedRate(feedrate);// 5); // 1000 == 10 mm / 5 s = 2 mm/s?????
           
            //gcode += GCodeLinMove(0, 0);

            gcode += GCode("M3 S255");
            // laser square
            // test square
            if (false)
            {
                gcode += GCodeLinMove(10, 0, 255);
                gcode += GCodeLinMove(10, 10, 255);
                gcode += GCodeLinMove(0, 10, 255);
                gcode += GCodeLinMove(0, 0, 255);
            }
            // actual drawing gets done here


            // first scale bitmap to right size
            int xpixels = (int)(exportwidth * (pixeldense / 25.4));
            int ypixels = (int)(exportheight * (pixeldense / 25.4));


            outputBMP = new Bitmap(xpixels, ypixels);

            using (System.Drawing.Graphics g = Graphics.FromImage(outputBMP))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(Picture, 0, 0, xpixels, ypixels);




            }
            pictureBox1.Image = outputBMP;
            pictureBox1.Update();
            
            for (int y = 0; y < ypixels; y++)
            {
                int prevpow = -1;
                int pow = 0;
                string boi = "";
                for (int x = 0; x < xpixels;)
                {
                    // draw pixeloutputBMP.GetPixel(x, y).R
                    int ahead = 0;

                    do
                    {
                        if (x >= xpixels )
                            break;
                        Color c = outputBMP.GetPixel(x, y);
                        pow = 255 - ((c.R + c.G + c.B) / 3);
                        if (InvertEngrave.Checked)
                            pow = 255 - pow;

                        if (ahead++ == 0) prevpow = pow;
                        x++;

                    }
                    while (pow == prevpow);

                    if(x!= 1)
                        pow = prevpow;

                    int engravepow = (pow * MaxDiodePower) / 255;
                    if (pow < MaxDiodePower)
                    {
                        boi += GCodeLinMove((double)(x) / (pixeldense / 25.4), (double)y / (pixeldense / 25.4), MaxDiodePower - engravepow);
                    }

                    else
                    {
                        boi += GCodeLinMove((double)(x) / (pixeldense / 25.4), (double)y / (pixeldense / 25.4));
                    }
                    prevpow = pow;
                    x++;
                }
                boi += GCodeFeedRate(140);
                boi += GCodeLinMove(0, (double)(y + 1) / (pixeldense / 25.4));
                boi += GCodeFeedRate(feedrate);

                gcode += boi; // because concatenating gcode is slow as malasus
                // move back
                //gcode +=
            }

            







            gcode += GCode("M3 S0"); // disable laser power
                                     // gcode += GCode("")


            renderGcode(gcode, exportwidth, exportheight, NozzleXOffset, NozzleYOffset);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\output.gcode";

            gcodemeuk = gcode.Split('\n');
            if (startengrave)
            {


                playing = true;
                cansend = true;
            }
            File.WriteAllText(path, gcode);


        }

        const int bedrendersize = 5000;
        private void renderGcode(string gcode, double bedsizex, double bedsizey, double xoffset, double yoffset)
        {
            string[] gcodes = gcode.Split('\n');

            Bitmap printbed = new Bitmap(bedrendersize, bedrendersize);
            double lastXpos = 0;
            double lastYpos = 0;  
            double scalarX = bedrendersize / bedsizex ;
            double scalarY = bedrendersize / bedsizey;
            double timecounter = 0; // 0s
            double currentfeedrate = 0;


            Pen pen = new Pen(Color.Black);
            pen.Width =  (int)scalarX/2;

            





            using (System.Drawing.Graphics g = Graphics.FromImage(printbed))
            {
               // g.FillRectangle(Brushes.White, 0,0,printbed.Size.Width,printbed.Size.Height);
                foreach (string code in gcodes)
                {
                    
                    if(code.Contains('F'))
                    {
                        string fstring = code.Split('F')[1].Split(' ')[0];
                       
                        fstring = fstring.Replace('.', ',').Replace("\r", "");
                        
                        currentfeedrate = double.Parse(fstring)/60; // mm per minute because marlin is weird like that...
                       
                    }

                    if(code.Contains("G0") || code.Contains("G1"))
                    {
                        if (code.Contains('X') && code.Contains('Y'))
                        {
                            string xstring = code.Split('X')[1].Split(' ')[0];
                            string ystring = code.Split('Y')[1].Split(' ')[0];
                            xstring = xstring.Replace('.', ',').Replace("\r", "");
                            ystring = ystring.Replace('.', ',').Replace("\r", "");
                            double x = double.Parse(xstring) - NozzleXOffset;
                            double y = double.Parse(ystring) - NozzleYOffset;

                            //move command, draw this is s>0
                            if (code.Contains('S'))
                            {
                                string sstring = code.Split('S')[1].Split(' ')[0];
                                sstring = sstring.Replace('.', ',').Replace("\r","");
                                
                                double s = double.Parse(sstring);

                                if (s > 0)
                                {
                                    pen.Color = Color.FromArgb((int)(255-s), (int)(255 - s), (int)(255 - s));
                                                        
                                    g.DrawLine(pen, new Point((int)(lastXpos * scalarX), (int)(lastYpos * scalarY)), new Point((int)(x * scalarX), (int)(y * scalarY)));
                                   // g.FillEllipse(Brushes.Red, new Rectangle((int)(x * scalarX - 40), (int)(y*scalarY -40), 40, 40));
                                
                                }
                                }

                            // calculate vector length and then use feedrate to calculate time passage
                            double lengthmoved = Math.Sqrt(Math.Pow(Math.Abs(x- lastXpos), 2) + Math.Pow(Math.Abs(y- lastYpos), 2));

                           
                            double secondsmoved = 1/(currentfeedrate / lengthmoved); // mm/s / mm = 1/s?
                            timecounter += secondsmoved;

                            lastXpos = x;
                            lastYpos = y;
                        }
                    }


                }
            }

            System.TimeSpan dt = new System.TimeSpan();

            dt = TimeSpan.FromSeconds(timecounter);
            TimeRemainingTb.Text = "Engrave time: " + dt.Hours + " hr " + dt.Minutes +" min "+ dt.Seconds + " sec";
            pictureBox1.Image = printbed;
            pictureBox1.Update();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialThicknessTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            engrave();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playing = false;
            index = 0;
        }
    }
}
