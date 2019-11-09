using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgrammingThings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnOn
            try
            {
                //truning on 
                serialPort1.Open();
                serialPort1.Write("2");             
                serialPort1.Close();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                labelDisplay.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                labelDisplay.SelectedIndex = 0;

                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            //btnOff
            try
            {
                //truning off
                serialPort1.Open();
                serialPort1.WriteLine("off");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Display Box
            try
            {
                serialPort1.PortName = labelDisplay.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackwards_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("3");
            serialPort1.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("1");
            serialPort1.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("2");
            serialPort1.Close();
        }
    }
}
