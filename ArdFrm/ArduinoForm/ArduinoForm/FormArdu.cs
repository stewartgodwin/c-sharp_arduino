using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoForm
{
    public partial class ArduForm : Form
    {
        public ArduForm()
        {
            InitializeComponent();
            Init(); // connect to COM serial port
        }

        private SerialPort myPort;
        bool blueLEDStatus = true;

        // initialise the com port for serial data
        private void Init()
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = "COM5"; // modify to your local COM
                myPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected");
            }
        }

        // code to control red LED
        // send text value 100 - arduino will parse to integer
        private void BtnRedOn_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("100");
        }
        // send text value 101 - arduino will parse to integer
        private void BtnRedOff_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("101");
        }
        // code to control blue LED - uses bool status
        private void BtnBlueLED_Click(object sender, EventArgs e)
        {
            if (blueLEDStatus)
            {
                myPort.WriteLine("200");
                blueLEDStatus = false;
            }
            else
            {
                myPort.WriteLine("201");
                blueLEDStatus = true;
            }
        }
        // send text value 300 - activate buzzer
        private void BtnBuzzer_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("300");
        }

    }
}
