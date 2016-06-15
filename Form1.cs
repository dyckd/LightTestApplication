using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Daniels_LightTestApplication
{
    public partial class MainForm : Form
    {

        private SerialPort comport7_interior = new SerialPort();
        private SerialPort comport8_exterior = new SerialPort();
        private SerialPort comport2_lightsensor = new SerialPort();
        


        public void
        OpenComport7()
        {
            if (comport7_interior.IsOpen)
            {
                comport7_interior.Close();
            }
            else
            {
                comport7_interior.PortName = "Comport 7";
                comport7_interior.BaudRate = 38400;
                comport7_interior.DataBits = 8;
                comport7_interior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1"); ;
                comport8_exterior.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                comport7_interior.Open();
            }
        }

        public void
        OpenComport8()
        {
            if (comport8_exterior.IsOpen)
            {
                comport8_exterior.Close();
            }
            else
            {
                comport8_exterior.PortName = "Comport 8";             
                comport8_exterior.BaudRate = 38400;
                comport8_exterior.DataBits = 8;
                comport8_exterior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport8_exterior.Parity   = (Parity)Enum.Parse(typeof(Parity), "None");
                comport8_exterior.Open();
            }
        }

        public void
        OpenComport2()
        // Open Comport 2 for any various light sensor
        {
            if (comport2_lightsensor.IsOpen)
            {
                comport2_lightsensor.Close();
            }
            else
            {
                comport2_lightsensor.PortName = "Comport 2";
                comport2_lightsensor.BaudRate = int.Parse(lightsensor_baudrate_db.Text);
                comport2_lightsensor.DataBits = int.Parse(lightsensor_databits_db.Text);
                comport2_lightsensor.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport2_lightsensor.Parity   = (Parity)Enum.Parse(typeof(Parity), lightsensor_parity_db.Text);
                comport2_lightsensor.Open();
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_runtest_Click(object sender, EventArgs e)
        {
            OpenComport7();
            OpenComport8();
            OpenComport2();

            // Byte data of command that moves Unit 1 160 steps = 4.5 degrees
            byte[] move_interior_160s = System.Text.Encoding.UTF8.GetBytes("@1N160");
            byte[] u1_go = System.Text.Encoding.UTF8.GetBytes("@1G");

            // Exterior Platform Loop
            for (int i = 0; i <= 3200; i += 160)
            {
                // Interior Platform Loop
                for (int ii = 0; i <= 6400; ii += 160)
                {
                    comport7_interior.Write(move_interior_160s, 0, 8);

                }

            
            }
  
        
        
        
        
        
        }
    }
}
