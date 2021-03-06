﻿namespace ProgrammingThings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox2;
            this.btnOff = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.ComboBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.bbtnTurn = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Course = new System.Windows.Forms.GroupBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_U_Turn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_search_right = new System.Windows.Forms.Button();
            this.btn_search_left = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update_course_readings = new System.Windows.Forms.Button();
            this.btn_right_corner = new System.Windows.Forms.Button();
            this.btn_left_corner = new System.Windows.Forms.Button();
            this.groupRCControls = new System.Windows.Forms.GroupBox();
            this.btn_ReturnHome = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.Course.SuspendLayout();
            this.groupRCControls.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(12, 80);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(157, 35);
            this.btnOff.TabIndex = 0;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.FormattingEnabled = true;
            this.labelDisplay.Location = new System.Drawing.Point(12, 12);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(157, 24);
            this.labelDisplay.TabIndex = 1;
            this.labelDisplay.SelectedIndexChanged += new System.EventHandler(this.labelDisplay_SelectedIndexChanged);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(12, 42);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(157, 32);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(139, 74);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "▲";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(139, 122);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBackwards
            // 
            this.btnBackwards.Location = new System.Drawing.Point(139, 174);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(91, 33);
            this.btnBackwards.TabIndex = 5;
            this.btnBackwards.Text = "▼";
            this.btnBackwards.UseVisualStyleBackColor = true;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(253, 122);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(91, 33);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(18, 122);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(91, 33);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // bbtnTurn
            // 
            this.bbtnTurn.Location = new System.Drawing.Point(253, 21);
            this.bbtnTurn.Name = "bbtnTurn";
            this.bbtnTurn.Size = new System.Drawing.Size(108, 43);
            this.bbtnTurn.TabIndex = 17;
            this.bbtnTurn.Text = "UTurn";
            this.bbtnTurn.UseVisualStyleBackColor = true;
            this.bbtnTurn.Click += new System.EventHandler(this.bbtnTurn_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(139, 21);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(91, 43);
            this.btnR.TabIndex = 18;
            this.btnR.Text = "Right";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(6, 21);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(108, 43);
            this.btnL.TabIndex = 19;
            this.btnL.Text = "Left";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Test Controller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 138);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 145);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // Course
            // 
            this.Course.Controls.Add(this.btn_ReturnHome);
            this.Course.Controls.Add(this.btn_c);
            this.Course.Controls.Add(this.btn_U_Turn);
            this.Course.Controls.Add(this.checkBox1);
            this.Course.Controls.Add(this.button2);
            this.Course.Controls.Add(this.label4);
            this.Course.Controls.Add(this.btn_stop);
            this.Course.Controls.Add(this.btn_search_right);
            this.Course.Controls.Add(this.btn_search_left);
            this.Course.Controls.Add(this.label3);
            this.Course.Controls.Add(this.label1);
            this.Course.Controls.Add(this.btn_update_course_readings);
            this.Course.Controls.Add(this.btn_right_corner);
            this.Course.Controls.Add(this.btn_left_corner);
            this.Course.Controls.Add(this.richTextBox1);
            this.Course.Location = new System.Drawing.Point(175, 12);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(906, 228);
            this.Course.TabIndex = 35;
            this.Course.TabStop = false;
            this.Course.Text = "Course Readings";
            this.Course.Enter += new System.EventHandler(this.CourseReadings_Enter);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(430, 165);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(152, 51);
            this.btn_c.TabIndex = 37;
            this.btn_c.Text = "Action Completed";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_U_Turn
            // 
            this.btn_U_Turn.Location = new System.Drawing.Point(432, 125);
            this.btn_U_Turn.Name = "btn_U_Turn";
            this.btn_U_Turn.Size = new System.Drawing.Size(150, 34);
            this.btn_U_Turn.TabIndex = 46;
            this.btn_U_Turn.Text = "U-Turn";
            this.btn_U_Turn.UseVisualStyleBackColor = true;
            this.btn_U_Turn.Click += new System.EventHandler(this.btn_U_Turn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(298, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Always Update";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 48);
            this.button2.TabIndex = 44;
            this.button2.Text = "Start Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Search rooms:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(432, 84);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(150, 35);
            this.btn_stop.TabIndex = 43;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_search_right
            // 
            this.btn_search_right.Location = new System.Drawing.Point(742, 165);
            this.btn_search_right.Name = "btn_search_right";
            this.btn_search_right.Size = new System.Drawing.Size(144, 51);
            this.btn_search_right.TabIndex = 38;
            this.btn_search_right.Text = "Search Right Room";
            this.btn_search_right.UseVisualStyleBackColor = true;
            this.btn_search_right.Click += new System.EventHandler(this.btn_search_right_Click);
            // 
            // btn_search_left
            // 
            this.btn_search_left.Location = new System.Drawing.Point(742, 108);
            this.btn_search_left.Name = "btn_search_left";
            this.btn_search_left.Size = new System.Drawing.Size(144, 51);
            this.btn_search_left.TabIndex = 37;
            this.btn_search_left.Text = "Search Left Room";
            this.btn_search_left.UseVisualStyleBackColor = true;
            this.btn_search_left.Click += new System.EventHandler(this.btn_search_left_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Corner actions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Course Actions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_update_course_readings
            // 
            this.btn_update_course_readings.Location = new System.Drawing.Point(6, 181);
            this.btn_update_course_readings.Name = "btn_update_course_readings";
            this.btn_update_course_readings.Size = new System.Drawing.Size(415, 35);
            this.btn_update_course_readings.TabIndex = 39;
            this.btn_update_course_readings.Text = "Update Readings";
            this.btn_update_course_readings.UseVisualStyleBackColor = true;
            this.btn_update_course_readings.Click += new System.EventHandler(this.btn_update_course_readings_Click);
            // 
            // btn_right_corner
            // 
            this.btn_right_corner.Location = new System.Drawing.Point(589, 165);
            this.btn_right_corner.Name = "btn_right_corner";
            this.btn_right_corner.Size = new System.Drawing.Size(144, 51);
            this.btn_right_corner.TabIndex = 36;
            this.btn_right_corner.Text = "Right Corner";
            this.btn_right_corner.UseVisualStyleBackColor = true;
            this.btn_right_corner.Click += new System.EventHandler(this.btn_right_corner_Click);
            // 
            // btn_left_corner
            // 
            this.btn_left_corner.Location = new System.Drawing.Point(588, 108);
            this.btn_left_corner.Name = "btn_left_corner";
            this.btn_left_corner.Size = new System.Drawing.Size(144, 51);
            this.btn_left_corner.TabIndex = 35;
            this.btn_left_corner.Text = "Left Coner";
            this.btn_left_corner.UseVisualStyleBackColor = true;
            this.btn_left_corner.Click += new System.EventHandler(this.btn_left_corner_Click);
            // 
            // groupRCControls
            // 
            this.groupRCControls.Controls.Add(this.btnL);
            this.groupRCControls.Controls.Add(this.btnR);
            this.groupRCControls.Controls.Add(this.bbtnTurn);
            this.groupRCControls.Controls.Add(this.btnLeft);
            this.groupRCControls.Controls.Add(this.btnStop);
            this.groupRCControls.Controls.Add(this.btnRight);
            this.groupRCControls.Controls.Add(this.btnGo);
            this.groupRCControls.Controls.Add(this.btnBackwards);
            this.groupRCControls.Location = new System.Drawing.Point(703, 246);
            this.groupRCControls.Name = "groupRCControls";
            this.groupRCControls.Size = new System.Drawing.Size(378, 231);
            this.groupRCControls.TabIndex = 36;
            this.groupRCControls.TabStop = false;
            this.groupRCControls.Text = "RC Controls";
            // 
            // btn_ReturnHome
            // 
            this.btn_ReturnHome.Location = new System.Drawing.Point(589, 32);
            this.btn_ReturnHome.Name = "btn_ReturnHome";
            this.btn_ReturnHome.Size = new System.Drawing.Size(296, 45);
            this.btn_ReturnHome.TabIndex = 47;
            this.btn_ReturnHome.Text = "Return home";
            this.btn_ReturnHome.UseVisualStyleBackColor = true;
            this.btn_ReturnHome.Click += new System.EventHandler(this.btn_ReturnHome_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(516, 199);
            this.richTextBox2.TabIndex = 37;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.richTextBox2);
            groupBox2.Location = new System.Drawing.Point(175, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(528, 231);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Course Proximity Readings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 488);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.groupRCControls);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btnOff);
            this.Name = "Form1";
            this.Text = "Zumo Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            this.groupRCControls.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.ComboBox labelDisplay;
        private System.Windows.Forms.Button btnOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBackwards;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button bbtnTurn;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox Course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update_course_readings;
        private System.Windows.Forms.Button btn_search_right;
        private System.Windows.Forms.Button btn_search_left;
        private System.Windows.Forms.Button btn_right_corner;
        private System.Windows.Forms.Button btn_left_corner;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupRCControls;
        private System.Windows.Forms.Button btn_U_Turn;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_ReturnHome;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

