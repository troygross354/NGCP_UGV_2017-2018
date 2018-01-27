using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;

namespace RoboticArm_XBoxController_GUI
{
    /// <summary>
    /// To use the XBox One controller, need to run the following commands on the NuGet Package Manager Console to include needed API
    /// Install-Package SharpDX
    /// Install-Package SharpDX.XInput -Version 3.1.1
    /// </summary>
    
    public partial class Form1 : Form
    {
        // properties
        /// <summary>
        /// The connected Xbox One controller. All properties are updated with in one of its methods.
        /// </summary>
        private XInputController xb1c;

        /// <summary>
        /// The id values for each of the servos. These are to be sent to the vehicle so it can know which one to write to.
        /// </summary>
        private const Int16 base_id = 11, shoulder_id = 12, elbow_id = 13, gripper_id = 14;

        /// <summary>
        /// The normalized value read from the controller. This should be multiplied by a gain, depending on each servo, and stored in a separtely to be sent.
        /// The Xbox One controller servo assignments is as follows:
        /// Base : Left joystick, X-direction
        /// Shoulder : Left joystick, Y-direction
        /// Elbow : Right joystick, Y-direction
        /// Gripper : Right joystick, X-direction
        /// </summary>
        private int base_val, shoulder_val, elbow_val, gripper_val;

        /// <summary>
        /// Gain values calculated
        /// </summary>
        private int g_base, g_shoulder, g_elbow, g_gripper;

        private void trackBar_elbow_ValueChanged(object sender, EventArgs e)
        {
            // send a packet to the UGV with the updated change values
            SendArmData(0x0F, elbow_id, trackBar_elbow.Value);
        }

        private void trackBar_gripper_ValueChanged(object sender, EventArgs e)
        {
            // send a packet to the UGV with the updated change values
            SendArmData(0x0F, gripper_id, trackBar_gripper.Value);
        }

        private void trackBar_shoulder_ValueChanged(object sender, EventArgs e)
        {
            // send a packet to the UGV with the updated change values
            SendArmData(0x0F, shoulder_id, trackBar_shoulder.Value);
        }

        private void trackBar_base_ValueChanged(object sender, EventArgs e)
        {
            // send a packet to the UGV with the updated change values
            SendArmData(0x0F, base_id, trackBar_base.Value);
        }

        /// <summary>
        /// The defined value each joystick coordinate must be passed in order to write any gain values.
        /// </summary>
        private const int Xthreshold = 30, Ythreshold = 30;

        public Form1()
        {
            InitializeComponent();

            // start a new instance of the xbox one controller
            xb1c = new XInputController();

            // if there is a connection then update the current values
            if (xb1c.connected)
            {
                base_val = xb1c.leftThumb.X;
                shoulder_val = xb1c.leftThumb.Y;
                elbow_val = xb1c.rightThumb.Y;
                gripper_val = xb1c.rightThumb.X;
            }
            else
                MessageBox.Show(this,"The Xbox One controller did not connect properly.\n","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            // set timer event to start reading and updating from the controller
            timer1.Start();
        }

        /// <summary>
        /// Event that is triggerd periodically. Currently the refresh is set to 10 Hz. This can be changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // update the values read from the xbox one controller
            xb1c.Update();
            UpdateControllerValues();
            // Calclulate the gain based on the positoin of each joystick
            CalculateGains();
            // Update slide bar values to reflect the changes that were sent
            UpdateTrackBars();
        }

        private void UpdateControllerValues()
        {
            // Left Joystick values
            lbl_LJSx.Text = String.Format("X: {0}", xb1c.leftThumb.X);
            lbl_LJSy.Text = String.Format("Y: {0}", xb1c.leftThumb.Y);

            // Right Joystick values
            lbl_RJSx.Text = String.Format("X: {0}", xb1c.rightThumb.X);
            lbl_RJSy.Text = String.Format("Y: {0}", xb1c.rightThumb.Y);

            // Controller connection status
            lbl_ControlConnect.Text = String.Format("Controller Connected: {0}", xb1c.connected ? "True" : "False");
        }

        private void CalculateGains()
        {
            // update class properties
            base_val = xb1c.leftThumb.X;
            shoulder_val = xb1c.leftThumb.Y;
            elbow_val = xb1c.rightThumb.Y;
            gripper_val = xb1c.rightThumb.X;

            // determine gains
            g_base = (int)(Math.Abs(base_val) > Xthreshold ? 2.0 * base_val : 0);
            g_shoulder = (int)(Math.Abs(shoulder_val) > Ythreshold ? 2.0 * shoulder_val : 0);
            g_elbow = (int)(Math.Abs(elbow_val) > Ythreshold ? 2.5 * elbow_val : 0);
            g_gripper = (int)(Math.Abs(gripper_val) > Xthreshold ? 4.0 * gripper_val : 0);
        }

        private void UpdateTrackBars()
        {
            // if there is a gian calculation then update the track bar. check to see if the new slide bar value would exceed 
            // the defined max and min of the slide bar
            if(g_base != 0)
            {
                if (trackBar_base.Value + g_base > trackBar_base.Maximum)
                    trackBar_base.Value = trackBar_base.Maximum;
                else if (trackBar_base.Value + g_base < trackBar_base.Minimum)
                    trackBar_base.Value = trackBar_base.Minimum;
                else
                    trackBar_base.Value += g_base;
            }
            if (g_shoulder != 0)
            {
                if (trackBar_shoulder.Value + g_shoulder > trackBar_shoulder.Maximum)
                    trackBar_shoulder.Value = trackBar_shoulder.Maximum;
                else if (trackBar_shoulder.Value + g_shoulder < trackBar_shoulder.Minimum)
                    trackBar_shoulder.Value = trackBar_shoulder.Minimum;
                else
                    trackBar_shoulder.Value += g_shoulder;
            }
            if (g_elbow != 0)
            {
                if (trackBar_elbow.Value + g_elbow > trackBar_elbow.Maximum)
                    trackBar_elbow.Value = trackBar_elbow.Maximum;
                else if (trackBar_elbow.Value + g_elbow < trackBar_elbow.Minimum)
                    trackBar_elbow.Value = trackBar_elbow.Minimum;
                else
                    trackBar_elbow.Value += g_elbow;
            }
            if (g_gripper != 0)
            {
                if (trackBar_gripper.Value + g_gripper > trackBar_gripper.Maximum)
                    trackBar_gripper.Value = trackBar_gripper.Maximum;
                else if (trackBar_gripper.Value + g_gripper < trackBar_gripper.Minimum)
                    trackBar_gripper.Value = trackBar_gripper.Minimum;
                else
                    trackBar_gripper.Value += g_gripper;
            }
        }

        private void SendArmData(Int16 headerInfo, int id_param, int position_param)
        {

        }
    }
}       
