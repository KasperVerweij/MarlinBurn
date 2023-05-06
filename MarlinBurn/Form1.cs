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
            textBox2.Text = zwaffel;
            if (playing)
            {

                if (cansend)
                {
                    cansend = false;
                    serialPort1.Write(gcodemeuk[index] + "\n");
                    textBox1.Text += gcodemeuk[index]+ "\n";  
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
            zwaffel += ser; 
            if(ser.Contains("ok"))
            {
                cansend = true;

            }

            //else


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
            // export gcode

            double exportwidth = Double.Parse(XSizeTb.Text);
            double exportheight = Double.Parse(YSixeTb.Text);
            double pixeldense = Double.Parse(DpiTb.Text);
            bool HomeZ = HomeZCheckBox.Checked;
            double MaterialThickness = Double.Parse(MaterialThicknessTb.Text);
            NozzleXOffset = Double.Parse(NozzleOffsX.Text);
            NozzleYOffset = Double.Parse(NozzOffsY.Text);






            string gcode = GCode("G28 X Y" + (HomeZ ? " Z" : ""));
            gcode += GCode("G90"); // absolute positioning
            if(HomeZ)
            {
                gcode += GCode("G0 Z" + GCodeFloat(MaterialThickness.ToString())); // Move up by how thick material is
            }
            gcode += GCode("M3I");

            // initial square
            gcode += GCodeLinMove(0, 0);
            gcode += GCodeLinMove(exportwidth, 0);
            gcode += GCodeLinMove(exportwidth, exportheight);
            gcode += GCodeLinMove(0, exportheight);
            gcode += GCodeLinMove(0, 0);

            gcode += GCode("M3 S255");
            // laser square
            // test square
            if (true)
            {
                gcode += GCodeLinMove(10, 0, 255);
                gcode += GCodeLinMove(10, 10, 255);
                gcode += GCodeLinMove(0, 10, 255);
                gcode += GCodeLinMove(0, 0, 255);
            }
            // actual drawing gets done here


            // first scale bitmap to right size
            int xpixels =(int)( exportwidth * (pixeldense/25.4));
            int ypixels = (int)(exportheight *( pixeldense/25.4));


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
                for (int x = 0; x < xpixels; x++)
                {
                    // draw pixeloutputBMP.GetPixel(x, y).R
                    Color c = outputBMP.GetPixel(x, y);
                    int pow = 255 -( (c.R + c.G + c.B )/3);
                    if (pow < 255)
                    {
                        gcode += GCodeLinMove((double)x / (pixeldense / 25.4), (double)y / (pixeldense / 25.4) ,255- pow);
                    }

                    else
                    {
                        gcode += GCodeLinMove((double)x / (pixeldense / 25.4), (double)y / (pixeldense / 25.4));
                    }
                }

                // move back
                gcode += GCodeLinMove(0, (double)y / (pixeldense / 25.4));
            }










            gcode += GCode("M3 S0"); // disable laser power
                                     // gcode += GCode("")


            renderGcode(gcode, exportwidth, exportheight, NozzleXOffset,NozzleYOffset);
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\output.gcode";

            gcodemeuk = gcode.Split('\n');
            playing = true;
            cansend = true;

            File.WriteAllText(path,gcode);
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

            Pen pen = new Pen(Color.Black);
            pen.Width =  (int)scalarX/2;

            





            using (System.Drawing.Graphics g = Graphics.FromImage(printbed))
            {
               // g.FillRectangle(Brushes.White, 0,0,printbed.Size.Width,printbed.Size.Height);
                foreach (string code in gcodes)
                {
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
                                                            //else
                                                            //  pen.Color = Color.Firebrick;// Color.FromArgb((int)(255 - s), (int)(255 - s), (int)(255 - s));

                                    g.DrawLine(pen, new Point((int)(lastXpos * scalarX), (int)(lastYpos * scalarY)), new Point((int)(x * scalarX), (int)(y * scalarY)));
                                }
                                }
                            lastXpos = x;
                            lastYpos = y;
                        }
                    }


                }
            }




            pictureBox1.Image = printbed;
            pictureBox1.Update();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialThicknessTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
