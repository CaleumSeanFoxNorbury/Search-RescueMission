using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


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
                incomingDataBox.Enabled = true;

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

        //--RC CONTROLS----------------------------------------------------
        private void btnBackwards_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("b"); //backwards
            serialPort1.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("g"); //go
            serialPort1.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("s"); //not working
            serialPort1.Close();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //left
            serialPort1.Open();
            serialPort1.WriteLine("l"); //not working 
            serialPort1.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //right
            serialPort1.Open();
            serialPort1.WriteLine("r"); //not working 
            serialPort1.Close();
        }

        //TURN DEGREES ---------------------------------------------------
        string degreesEntered;
        private void txtDegreesEntered_TextChanged(object sender, EventArgs e)
        {
            degreesEntered = txtDegreesEntered.Text;
        }

        private void btnDegrees_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine(degreesEntered);
            serialPort1.Close();
        }
        //-----------------------------------------------------------------

        private void bbtnTurn_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("8");
            serialPort1.Close();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("l");
            serialPort1.Close();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("r");
            serialPort1.Close();
        }

        private void IncomingDataBox_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Open();
            incomingDataBox.ReadOnly = true;
            
            this.KeyPreview = true;

           
            if (incomingDataBox.Enabled == true){
                incomingDataBox.Text = "Worked";
            }

            Console.WriteLine("Loading in zumo readings");

            // string incomingData = serialPort1.ReadExisting();

            // incomingDataBox.Text =  incomingData;

           // incomingDataBox.Text = "failed";

            serialPort1.Close();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            //GROUP BOX
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("t"); //go
            serialPort1.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            incomingDataBox.Enabled = true;
            // Application.DoEvents();
        }
    }
}
