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
            if (playing)
            {

                if (cansend)
                {
                    serialPort1.Write(gcodemeuk[index] + "\n");
                    textBox1.Text += gcodemeuk[index]+ "\n";  
                    index++;
                    cansend = false;
                }

               
                if(index >= gcodemeuk.Length)
                { playing = false;
                    index = 0;
                }
            }        
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // is ok signal
            cansend = true;
           // if (serialPort1.BytesToRead > 1)
             //   if (serialPort1.ReadLine().Contains("ok"))
                   
            //else
               

        }
    }
}
