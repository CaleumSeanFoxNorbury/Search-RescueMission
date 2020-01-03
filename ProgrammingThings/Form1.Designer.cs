namespace ProgrammingThings
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
            this.btnOff = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.ComboBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtDegreesEntered = new System.Windows.Forms.TextBox();
            this.TurnDegrees = new System.Windows.Forms.Label();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.bbtnTurn = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incomingDataBox = new System.Windows.Forms.RichTextBox();
            this.ReadingsSector = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ReadingsSector.SuspendLayout();
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
            this.btnGo.Location = new System.Drawing.Point(991, 339);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "▲";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(991, 387);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBackwards
            // 
            this.btnBackwards.Location = new System.Drawing.Point(991, 439);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(91, 33);
            this.btnBackwards.TabIndex = 5;
            this.btnBackwards.Text = "▼";
            this.btnBackwards.UseVisualStyleBackColor = true;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1105, 387);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(91, 33);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(870, 387);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(91, 33);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtDegreesEntered
            // 
            this.txtDegreesEntered.Location = new System.Drawing.Point(982, 9);
            this.txtDegreesEntered.Name = "txtDegreesEntered";
            this.txtDegreesEntered.Size = new System.Drawing.Size(100, 22);
            this.txtDegreesEntered.TabIndex = 8;
            this.txtDegreesEntered.TextChanged += new System.EventHandler(this.txtDegreesEntered_TextChanged);
            // 
            // TurnDegrees
            // 
            this.TurnDegrees.AutoSize = true;
            this.TurnDegrees.Location = new System.Drawing.Point(844, 12);
            this.TurnDegrees.Name = "TurnDegrees";
            this.TurnDegrees.Size = new System.Drawing.Size(132, 17);
            this.TurnDegrees.TabIndex = 9;
            this.TurnDegrees.Text = "Enter Turn degrees";
            // 
            // btnDegrees
            // 
            this.btnDegrees.Location = new System.Drawing.Point(1088, 3);
            this.btnDegrees.Name = "btnDegrees";
            this.btnDegrees.Size = new System.Drawing.Size(108, 33);
            this.btnDegrees.TabIndex = 10;
            this.btnDegrees.Text = "EnterDegrees";
            this.btnDegrees.UseVisualStyleBackColor = true;
            this.btnDegrees.Click += new System.EventHandler(this.btnDegrees_Click);
            // 
            // bbtnTurn
            // 
            this.bbtnTurn.Location = new System.Drawing.Point(1088, 276);
            this.bbtnTurn.Name = "bbtnTurn";
            this.bbtnTurn.Size = new System.Drawing.Size(108, 43);
            this.bbtnTurn.TabIndex = 17;
            this.bbtnTurn.Text = "UTurn";
            this.bbtnTurn.UseVisualStyleBackColor = true;
            this.bbtnTurn.Click += new System.EventHandler(this.bbtnTurn_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(974, 276);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(108, 43);
            this.btnR.TabIndex = 18;
            this.btnR.Text = "Right";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(853, 276);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(108, 43);
            this.btnL.TabIndex = 19;
            this.btnL.Text = "Left";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Object detected: ";
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
            this.groupBox1.Size = new System.Drawing.Size(166, 133);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // incomingDataBox
            // 
            this.incomingDataBox.Location = new System.Drawing.Point(6, 30);
            this.incomingDataBox.Name = "incomingDataBox";
            this.incomingDataBox.Size = new System.Drawing.Size(244, 378);
            this.incomingDataBox.TabIndex = 29;
            this.incomingDataBox.Text = "";
            this.incomingDataBox.TextChanged += new System.EventHandler(this.IncomingDataBox_TextChanged);
            // 
            // ReadingsSector
            // 
            this.ReadingsSector.Controls.Add(this.btnUpdate);
            this.ReadingsSector.Controls.Add(this.incomingDataBox);
            this.ReadingsSector.Location = new System.Drawing.Point(184, 12);
            this.ReadingsSector.Name = "ReadingsSector";
            this.ReadingsSector.Size = new System.Drawing.Size(256, 460);
            this.ReadingsSector.TabIndex = 31;
            this.ReadingsSector.TabStop = false;
            this.ReadingsSector.Text = "ReadingsSector";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 40);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update Readings";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReadingsSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.bbtnTurn);
            this.Controls.Add(this.btnDegrees);
            this.Controls.Add(this.TurnDegrees);
            this.Controls.Add(this.txtDegreesEntered);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBackwards);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btnOff);
            this.Name = "Form1";
            this.Text = "Zumo Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ReadingsSector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtDegreesEntered;
        private System.Windows.Forms.Label TurnDegrees;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button bbtnTurn;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox incomingDataBox;
        private System.Windows.Forms.GroupBox ReadingsSector;
        private System.Windows.Forms.Button btnUpdate;
    }
}

