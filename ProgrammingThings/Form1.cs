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
                //setting up, enables, and setters
                labelDisplay.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                labelDisplay.SelectedIndex = 0;
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
            
                checkBox1.Enabled = true;
                checkBox1.Checked = true;

                //Thread for constent looping(Used for constently getting serial port data)
                new Thread(() =>
                {
                    //setting the thread in the background
                    Thread.CurrentThread.IsBackground = true;                    
                    UpdateReadings();
                
                }).Start();//start
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
                //user feedback
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

        private void btnBackwards_Click(object sender, EventArgs e)
        {
            //backwards
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
            //Testing button |  functionality changes depending on certain tests.
            serialPort1.WriteLine("h"); 
            Console.WriteLine("t sent");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Loading in zumo readings");
            //this text box updates somewhere else.     
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
            //send l to zumo
            serialPort1.WriteLine("l");
        }

        private void btn_right_corner_Click(object sender, EventArgs e)
        {
            //send r to zumo
            serialPort1.WriteLine("r");
        }

        private void btn_search_left_Click(object sender, EventArgs e)
        {
            //send l to zumo again.
            serialPort1.WriteLine("l");
        }

        private void btn_search_right_Click(object sender, EventArgs e)
        {
            //send r to zumo again.
            serialPort1.WriteLine("r");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //send a to zumo.
            serialPort1.WriteLine("s");
        }

        private void btn_update_course_readings_Click(object sender, EventArgs e)
        {
            //update course readings manually 
            if(checkBox1.Checked == false)
            {
                //Do nothing, updates somewhere else...
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

            //NOTE: This code is not used but could come useful when dealing with checked box change value.
            //IS REQUIRED!
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
            //while check box update is true then...
            while (checkBox1.Checked == true)
            {
                //get serial port reading
                string reading = checkForIncomingString();
                if (reading == "" || reading == null)
                {
                    //if not readings from serial port
                    richTextBox1.Invoke(new Action(() => { richTextBox1.Text = "Waiting for reading..."; }));

                }          
                else
                {
                    //if serial port has readings then display within rich text box
                    richTextBox1.Invoke(new Action(() => { richTextBox1.Text = reading; }));
                    Thread.Sleep(3000); //same as arduino file
                }
            }
        }

        private string checkForIncomingString()
        {
            //checks for incoming string...
            incomingString = serialPort1.ReadExisting();
            if (incomingString == "" || incomingString == null)
            {
                //if serial port is null then send null or "".
                return "";
            }     
            else
            {
                //is serial port has a reading then send the reading back to be displayed.
                return incomingString;
            }
        }

        private void btn_U_Turn_Click(object sender, EventArgs e)
        {
            //send 8 | U-Turn
            serialPort1.WriteLine("8");
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            //send c | completed course action | start course.
            serialPort1.WriteLine("c");
        }

        private void btn_ReturnHome_Click(object sender, EventArgs e)
        {
            //send h | return home functions.
            serialPort1.WriteLine("h");
        }

        private void CourseReadings_Enter(object sender, EventArgs e)
        {
            //Group box | no code needed.
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            serialPort1.WriteLine("q");
        }
    }
}
