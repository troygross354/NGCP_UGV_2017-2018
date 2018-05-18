namespace RoboticArm_XBoxController_GUI
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBar_base = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar_ArmY = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_armX = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblElbow_pp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblShoulder_pp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBase_pp = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGripper_pp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_Change_State = new System.Windows.Forms.RadioButton();
            this.rdb_Write = new System.Windows.Forms.RadioButton();
            this.rdb_NotWrite = new System.Windows.Forms.RadioButton();
            this.radioButton_retracted = new System.Windows.Forms.RadioButton();
            this.radioButton_closed = new System.Windows.Forms.RadioButton();
            this.groupBox_GripperServo = new System.Windows.Forms.GroupBox();
            this.trackBar_gimbalX = new System.Windows.Forms.TrackBar();
            this.trackBar_gimbalY = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ArmY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_armX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox_GripperServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gimbalX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gimbalY)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(709, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "120";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 66);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "-120";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(508, 18);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 20);
            this.label20.TabIndex = 42;
            this.label20.Text = "Base Servo";
            // 
            // trackBar_base
            // 
            this.trackBar_base.Location = new System.Drawing.Point(382, 46);
            this.trackBar_base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_base.Maximum = 120;
            this.trackBar_base.Minimum = -120;
            this.trackBar_base.Name = "trackBar_base";
            this.trackBar_base.Size = new System.Drawing.Size(318, 69);
            this.trackBar_base.SmallChange = 5;
            this.trackBar_base.TabIndex = 41;
            this.trackBar_base.ValueChanged += new System.EventHandler(this.trackBar_base_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Extended";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(292, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Retracted";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Arm Y Servo";
            // 
            // trackBar_ArmY
            // 
            this.trackBar_ArmY.Location = new System.Drawing.Point(382, 171);
            this.trackBar_ArmY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_ArmY.Maximum = 203;
            this.trackBar_ArmY.Name = "trackBar_ArmY";
            this.trackBar_ArmY.Size = new System.Drawing.Size(318, 69);
            this.trackBar_ArmY.SmallChange = 5;
            this.trackBar_ArmY.TabIndex = 37;
            this.trackBar_ArmY.ValueChanged += new System.EventHandler(this.trackBar_ArmY_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Extended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(292, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Retracted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Arm X Servo";
            // 
            // trackBar_armX
            // 
            this.trackBar_armX.Location = new System.Drawing.Point(383, 300);
            this.trackBar_armX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_armX.Maximum = 120;
            this.trackBar_armX.Name = "trackBar_armX";
            this.trackBar_armX.Size = new System.Drawing.Size(318, 69);
            this.trackBar_armX.SmallChange = 5;
            this.trackBar_armX.TabIndex = 33;
            this.trackBar_armX.ValueChanged += new System.EventHandler(this.trackBar_armX_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblElbow_pp);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(14, 288);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(243, 80);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arm X";
            // 
            // lblElbow_pp
            // 
            this.lblElbow_pp.AutoSize = true;
            this.lblElbow_pp.Location = new System.Drawing.Point(152, 34);
            this.lblElbow_pp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElbow_pp.Name = "lblElbow_pp";
            this.lblElbow_pp.Size = new System.Drawing.Size(24, 20);
            this.lblElbow_pp.TabIndex = 3;
            this.lblElbow_pp.Text = "---";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Present Position: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblShoulder_pp);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(14, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(243, 86);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arm Y";
            // 
            // lblShoulder_pp
            // 
            this.lblShoulder_pp.AutoSize = true;
            this.lblShoulder_pp.Location = new System.Drawing.Point(152, 34);
            this.lblShoulder_pp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShoulder_pp.Name = "lblShoulder_pp";
            this.lblShoulder_pp.Size = new System.Drawing.Size(24, 20);
            this.lblShoulder_pp.TabIndex = 3;
            this.lblShoulder_pp.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Present Position: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBase_pp);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(14, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(243, 78);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base";
            // 
            // lblBase_pp
            // 
            this.lblBase_pp.AutoSize = true;
            this.lblBase_pp.Location = new System.Drawing.Point(152, 34);
            this.lblBase_pp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase_pp.Name = "lblBase_pp";
            this.lblBase_pp.Size = new System.Drawing.Size(24, 20);
            this.lblBase_pp.TabIndex = 3;
            this.lblBase_pp.Text = "---";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 34);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Present Position: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGripper_pp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(14, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(243, 80);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gripper";
            // 
            // lblGripper_pp
            // 
            this.lblGripper_pp.AutoSize = true;
            this.lblGripper_pp.Location = new System.Drawing.Point(152, 34);
            this.lblGripper_pp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGripper_pp.Name = "lblGripper_pp";
            this.lblGripper_pp.Size = new System.Drawing.Size(24, 20);
            this.lblGripper_pp.TabIndex = 3;
            this.lblGripper_pp.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Present Position: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_Change_State);
            this.groupBox5.Controls.Add(this.rdb_Write);
            this.groupBox5.Controls.Add(this.rdb_NotWrite);
            this.groupBox5.Location = new System.Drawing.Point(870, 39);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(225, 158);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Packet Header";
            // 
            // rdb_Change_State
            // 
            this.rdb_Change_State.AutoSize = true;
            this.rdb_Change_State.Location = new System.Drawing.Point(6, 101);
            this.rdb_Change_State.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Change_State.Name = "rdb_Change_State";
            this.rdb_Change_State.Size = new System.Drawing.Size(186, 24);
            this.rdb_Change_State.TabIndex = 2;
            this.rdb_Change_State.Text = "Change_State : 0xFF";
            this.rdb_Change_State.UseVisualStyleBackColor = true;
            // 
            // rdb_Write
            // 
            this.rdb_Write.AutoSize = true;
            this.rdb_Write.Checked = true;
            this.rdb_Write.Location = new System.Drawing.Point(7, 70);
            this.rdb_Write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Write.Name = "rdb_Write";
            this.rdb_Write.Size = new System.Drawing.Size(176, 24);
            this.rdb_Write.TabIndex = 1;
            this.rdb_Write.TabStop = true;
            this.rdb_Write.Text = "Write_Packet : 0x0F";
            this.rdb_Write.UseVisualStyleBackColor = true;
            // 
            // rdb_NotWrite
            // 
            this.rdb_NotWrite.AutoSize = true;
            this.rdb_NotWrite.Location = new System.Drawing.Point(7, 39);
            this.rdb_NotWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_NotWrite.Name = "rdb_NotWrite";
            this.rdb_NotWrite.Size = new System.Drawing.Size(175, 24);
            this.rdb_NotWrite.TabIndex = 0;
            this.rdb_NotWrite.Text = "!Write_Packet: 0x00";
            this.rdb_NotWrite.UseVisualStyleBackColor = true;
            // 
            // radioButton_retracted
            // 
            this.radioButton_retracted.AutoSize = true;
            this.radioButton_retracted.Location = new System.Drawing.Point(54, 26);
            this.radioButton_retracted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_retracted.Name = "radioButton_retracted";
            this.radioButton_retracted.Size = new System.Drawing.Size(105, 24);
            this.radioButton_retracted.TabIndex = 50;
            this.radioButton_retracted.TabStop = true;
            this.radioButton_retracted.Text = "Retracted";
            this.radioButton_retracted.UseVisualStyleBackColor = true;
            this.radioButton_retracted.Click += new System.EventHandler(this.radioButton_retracted_Click);
            // 
            // radioButton_closed
            // 
            this.radioButton_closed.AutoSize = true;
            this.radioButton_closed.Location = new System.Drawing.Point(54, 60);
            this.radioButton_closed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_closed.Name = "radioButton_closed";
            this.radioButton_closed.Size = new System.Drawing.Size(83, 24);
            this.radioButton_closed.TabIndex = 51;
            this.radioButton_closed.TabStop = true;
            this.radioButton_closed.Text = "Closed";
            this.radioButton_closed.UseVisualStyleBackColor = true;
            this.radioButton_closed.Click += new System.EventHandler(this.radioButton_closed_Click);
            // 
            // groupBox_GripperServo
            // 
            this.groupBox_GripperServo.Controls.Add(this.radioButton_retracted);
            this.groupBox_GripperServo.Controls.Add(this.radioButton_closed);
            this.groupBox_GripperServo.Location = new System.Drawing.Point(454, 378);
            this.groupBox_GripperServo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_GripperServo.Name = "groupBox_GripperServo";
            this.groupBox_GripperServo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_GripperServo.Size = new System.Drawing.Size(173, 105);
            this.groupBox_GripperServo.TabIndex = 52;
            this.groupBox_GripperServo.TabStop = false;
            this.groupBox_GripperServo.Text = "Gripper Servo";
            // 
            // trackBar_gimbalX
            // 
            this.trackBar_gimbalX.Location = new System.Drawing.Point(800, 248);
            this.trackBar_gimbalX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_gimbalX.Maximum = 360;
            this.trackBar_gimbalX.Name = "trackBar_gimbalX";
            this.trackBar_gimbalX.Size = new System.Drawing.Size(295, 69);
            this.trackBar_gimbalX.SmallChange = 5;
            this.trackBar_gimbalX.TabIndex = 53;
            this.trackBar_gimbalX.ValueChanged += new System.EventHandler(this.trackBar_gimbalX_ValueChanged);
            // 
            // trackBar_gimbalY
            // 
            this.trackBar_gimbalY.Location = new System.Drawing.Point(800, 359);
            this.trackBar_gimbalY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_gimbalY.Maximum = 100;
            this.trackBar_gimbalY.Name = "trackBar_gimbalY";
            this.trackBar_gimbalY.Size = new System.Drawing.Size(295, 69);
            this.trackBar_gimbalY.SmallChange = 5;
            this.trackBar_gimbalY.TabIndex = 54;
            this.trackBar_gimbalY.ValueChanged += new System.EventHandler(this.trackBar_gimbalY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "GimbalY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(897, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "GimbalX";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(912, 436);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 47);
            this.Reset.TabIndex = 57;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 58;
            this.button1.Text = "Lidar Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_gimbalY);
            this.Controls.Add(this.trackBar_gimbalX);
            this.Controls.Add(this.groupBox_GripperServo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.trackBar_base);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.trackBar_ArmY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_armX);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ArmY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_armX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox_GripperServo.ResumeLayout(false);
            this.groupBox_GripperServo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gimbalX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gimbalY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBar_base;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBar_ArmY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_armX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblElbow_pp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblShoulder_pp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBase_pp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGripper_pp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_Change_State;
        private System.Windows.Forms.RadioButton rdb_Write;
        private System.Windows.Forms.RadioButton rdb_NotWrite;
        private System.Windows.Forms.RadioButton radioButton_retracted;
        private System.Windows.Forms.RadioButton radioButton_closed;
        private System.Windows.Forms.GroupBox groupBox_GripperServo;
        private System.Windows.Forms.TrackBar trackBar_gimbalY;
        private System.Windows.Forms.TrackBar trackBar_gimbalX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button1;
    }
}

