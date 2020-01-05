﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ProgrammingThings
{
    public partial class Form1 : Form
    {
        //global and instances 
        string incomingString;

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
                checkBox1.Enabled = true;
                checkBox1.Checked = true;
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
                //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);              
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    UpdateReadings();
                }).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {            
            try
            {
                //truning off serial port connection.
                serialPort1.Close();
                Console.WriteLine("Port Off");                
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
            //backwards
            serialPort1.Open();
            serialPort1.WriteLine("b");         
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //go
            serialPort1.WriteLine("g");              
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //stop
            serialPort1.WriteLine("s");    
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //left
            serialPort1.WriteLine("l");             
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //right
            serialPort1.WriteLine("r");          
        }

        private void bbtnTurn_Click(object sender, EventArgs e)
        {
            //Uturn
            serialPort1.WriteLine("8");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            //left
            serialPort1.WriteLine("l");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            //right
            serialPort1.WriteLine("r");
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            //GROUP BOX
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("t"); //testing 
            Console.WriteLine("t sent");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Loading in zumo readings");
                  
            //UpdateCourseReadings();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //LABEL | NO CODE REQURIED!
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //LABEL | NO CODE REQURIED!
        }

        private void btn_left_corner_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("l");
        }

        private void btn_right_corner_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r");
        }

        private void btn_search_left_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("l");
        }

        private void btn_search_right_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("s");
        }

        private void btn_update_course_readings_Click(object sender, EventArgs e)
        {
            //update course readings manually 
            if(checkBox1.Checked == false)
            {

            }
            else
            {
                //updates it automatically...
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //start course 
            serialPort1.WriteLine("c");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //check box for constent loop | always update course readings sector.
            serialPort1.Open();
            incomingString = serialPort1.ReadExisting();
            if (incomingString == "" || incomingString == null)
            {
                richTextBox1.Text = "No Data Recieved!";
            }
            else
            {
                richTextBox1.Text = incomingString;
            }
            serialPort1.Close();
        }

        private async void UpdateReadings()
        {
            serialPort1.Open();
            while (checkBox1.Checked == true)
            {
                string reading = checkForIncomingString();
                if (reading == "" || reading == null)
                {
                    richTextBox1.Invoke(new Action(() => { richTextBox1.Text = "Waiting for reading..."; }));
                }
                else
                {
                    richTextBox1.Invoke(new Action(() => { richTextBox1.Text = reading; }));
                    Thread.Sleep(3000); //same as arduino file
                }              
            }
        }

        private string checkForIncomingString()
        {
            incomingString = serialPort1.ReadExisting();
            if (incomingString == "" || incomingString == null)
            {
                return "";
            }
            else
            {
                return incomingString;
            }
        }
    }
}
