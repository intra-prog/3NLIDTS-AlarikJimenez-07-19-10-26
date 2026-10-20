using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_AlarikJimenez_07_19_10_26
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM9"; 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();


            this.FormClosing += CerrandoForm1;
            this.btnEncender.Click += btnEncender_Click;
            this.btnApagar.Click += btnApagar_Click;
        }

        private void CerrandoForm1(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    }
}
