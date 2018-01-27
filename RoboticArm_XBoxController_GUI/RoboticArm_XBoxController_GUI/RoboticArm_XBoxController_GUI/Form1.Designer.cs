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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_LJSx = new System.Windows.Forms.Label();
            this.lbl_LJSy = new System.Windows.Forms.Label();
            this.lbl_RJSy = new System.Windows.Forms.Label();
            this.lbl_RJSx = new System.Windows.Forms.Label();
            this.lbl_ControlConnect = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.trackBar_gripper = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBar_base = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar_shoulder = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_elbow = new System.Windows.Forms.TrackBar();
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_NotWrite = new System.Windows.Forms.RadioButton();
            this.rdb_Write = new System.Windows.Forms.RadioButton();
            this.rdb_Change_State = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gripper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shoulder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_elbow)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Joystick:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right Joystick:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LJSx
            // 
            this.lbl_LJSx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LJSx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LJSx.Location = new System.Drawing.Point(221, 14);
            this.lbl_LJSx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LJSx.Name = "lbl_LJSx";
            this.lbl_LJSx.Size = new System.Drawing.Size(117, 37);
            this.lbl_LJSx.TabIndex = 2;
            this.lbl_LJSx.Text = "X:";
            this.lbl_LJSx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LJSy
            // 
            this.lbl_LJSy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LJSy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LJSy.Location = new System.Drawing.Point(369, 14);
            this.lbl_LJSy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LJSy.Name = "lbl_LJSy";
            this.lbl_LJSy.Size = new System.Drawing.Size(102, 37);
            this.lbl_LJSy.TabIndex = 3;
            this.lbl_LJSy.Text = "Y:";
            this.lbl_LJSy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_RJSy
            // 
            this.lbl_RJSy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_RJSy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RJSy.Location = new System.Drawing.Point(369, 68);
            this.lbl_RJSy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RJSy.Name = "lbl_RJSy";
            this.lbl_RJSy.Size = new System.Drawing.Size(102, 33);
            this.lbl_RJSy.TabIndex = 5;
            this.lbl_RJSy.Text = "Y:";
            this.lbl_RJSy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_RJSx
            // 
            this.lbl_RJSx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_RJSx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RJSx.Location = new System.Drawing.Point(217, 65);
            this.lbl_RJSx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RJSx.Name = "lbl_RJSx";
            this.lbl_RJSx.Size = new System.Drawing.Size(121, 36);
            this.lbl_RJSx.TabIndex = 4;
            this.lbl_RJSx.Text = "X:";
            this.lbl_RJSx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ControlConnect
            // 
            this.lbl_ControlConnect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ControlConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControlConnect.Location = new System.Drawing.Point(513, 24);
            this.lbl_ControlConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ControlConnect.Name = "lbl_ControlConnect";
            this.lbl_ControlConnect.Size = new System.Drawing.Size(235, 74);
            this.lbl_ControlConnect.TabIndex = 6;
            this.lbl_ControlConnect.Text = "Controller Connected: False";
            this.lbl_ControlConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(709, 515);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 20);
            this.label22.TabIndex = 47;
            this.label22.Text = "Closed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(509, 468);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 20);
            this.label24.TabIndex = 46;
            this.label24.Text = "Gripper Servo";
            // 
            // trackBar_gripper
            // 
            this.trackBar_gripper.Location = new System.Drawing.Point(382, 492);
            this.trackBar_gripper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_gripper.Maximum = 3700;
            this.trackBar_gripper.Minimum = 700;
            this.trackBar_gripper.Name = "trackBar_gripper";
            this.trackBar_gripper.Size = new System.Drawing.Size(318, 69);
            this.trackBar_gripper.SmallChange = 100;
            this.trackBar_gripper.TabIndex = 45;
            this.trackBar_gripper.Value = 2200;
            this.trackBar_gripper.ValueChanged += new System.EventHandler(this.trackBar_gripper_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(709, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "90";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 161);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "-90";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(509, 112);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 20);
            this.label20.TabIndex = 42;
            this.label20.Text = "Base Servo";
            // 
            // trackBar_base
            // 
            this.trackBar_base.Location = new System.Drawing.Point(382, 141);
            this.trackBar_base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_base.Maximum = 3700;
            this.trackBar_base.Minimum = 700;
            this.trackBar_base.Name = "trackBar_base";
            this.trackBar_base.Size = new System.Drawing.Size(318, 69);
            this.trackBar_base.SmallChange = 100;
            this.trackBar_base.TabIndex = 41;
            this.trackBar_base.Value = 2200;
            this.trackBar_base.ValueChanged += new System.EventHandler(this.trackBar_base_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 286);
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
            this.label9.Location = new System.Drawing.Point(292, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Retracted";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(487, 237);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Shoulder Servo";
            // 
            // trackBar_shoulder
            // 
            this.trackBar_shoulder.Location = new System.Drawing.Point(382, 266);
            this.trackBar_shoulder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_shoulder.Maximum = 3700;
            this.trackBar_shoulder.Minimum = 700;
            this.trackBar_shoulder.Name = "trackBar_shoulder";
            this.trackBar_shoulder.Size = new System.Drawing.Size(318, 69);
            this.trackBar_shoulder.SmallChange = 100;
            this.trackBar_shoulder.TabIndex = 37;
            this.trackBar_shoulder.Value = 2200;
            this.trackBar_shoulder.ValueChanged += new System.EventHandler(this.trackBar_shoulder_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 417);
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
            this.label3.Location = new System.Drawing.Point(709, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Retracted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Elbow Servo";
            // 
            // trackBar_elbow
            // 
            this.trackBar_elbow.Location = new System.Drawing.Point(382, 394);
            this.trackBar_elbow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_elbow.Maximum = 3700;
            this.trackBar_elbow.Minimum = 700;
            this.trackBar_elbow.Name = "trackBar_elbow";
            this.trackBar_elbow.Size = new System.Drawing.Size(318, 69);
            this.trackBar_elbow.SmallChange = 100;
            this.trackBar_elbow.TabIndex = 33;
            this.trackBar_elbow.Value = 2200;
            this.trackBar_elbow.ValueChanged += new System.EventHandler(this.trackBar_elbow_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblElbow_pp);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(13, 383);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(243, 80);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elbow";
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
            this.groupBox3.Location = new System.Drawing.Point(13, 249);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(243, 86);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shoulder";
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
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(243, 77);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 481);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(292, 515);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Retracted";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_Change_State);
            this.groupBox5.Controls.Add(this.rdb_Write);
            this.groupBox5.Controls.Add(this.rdb_NotWrite);
            this.groupBox5.Location = new System.Drawing.Point(768, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 157);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Packet Header";
            // 
            // rdb_NotWrite
            // 
            this.rdb_NotWrite.AutoSize = true;
            this.rdb_NotWrite.Location = new System.Drawing.Point(6, 25);
            this.rdb_NotWrite.Name = "rdb_NotWrite";
            this.rdb_NotWrite.Size = new System.Drawing.Size(175, 24);
            this.rdb_NotWrite.TabIndex = 0;
            this.rdb_NotWrite.Text = "!Write_Packet: 0x00";
            this.rdb_NotWrite.UseVisualStyleBackColor = true;
            // 
            // rdb_Write
            // 
            this.rdb_Write.AutoSize = true;
            this.rdb_Write.Checked = true;
            this.rdb_Write.Location = new System.Drawing.Point(6, 62);
            this.rdb_Write.Name = "rdb_Write";
            this.rdb_Write.Size = new System.Drawing.Size(176, 24);
            this.rdb_Write.TabIndex = 1;
            this.rdb_Write.TabStop = true;
            this.rdb_Write.Text = "Write_Packet : 0x0F";
            this.rdb_Write.UseVisualStyleBackColor = true;
            // 
            // rdb_Change_State
            // 
            this.rdb_Change_State.AutoSize = true;
            this.rdb_Change_State.Location = new System.Drawing.Point(6, 101);
            this.rdb_Change_State.Name = "rdb_Change_State";
            this.rdb_Change_State.Size = new System.Drawing.Size(186, 24);
            this.rdb_Change_State.TabIndex = 2;
            this.rdb_Change_State.Text = "Change_State : 0xFF";
            this.rdb_Change_State.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 580);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.trackBar_gripper);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.trackBar_base);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.trackBar_shoulder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_elbow);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_ControlConnect);
            this.Controls.Add(this.lbl_RJSy);
            this.Controls.Add(this.lbl_RJSx);
            this.Controls.Add(this.lbl_LJSy);
            this.Controls.Add(this.lbl_LJSx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gripper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shoulder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_elbow)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_LJSx;
        private System.Windows.Forms.Label lbl_LJSy;
        private System.Windows.Forms.Label lbl_RJSy;
        private System.Windows.Forms.Label lbl_RJSx;
        private System.Windows.Forms.Label lbl_ControlConnect;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar trackBar_gripper;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBar_base;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBar_shoulder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_elbow;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_Change_State;
        private System.Windows.Forms.RadioButton rdb_Write;
        private System.Windows.Forms.RadioButton rdb_NotWrite;
    }
}

