using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_Denied
{
    class Program
    {
        static void Main(string[] args)
        {
            double UAV_X_GPS_Coordinate = 3; // Enter UAV X Coordinate
            double UAV_Y_GPS_Coordinate = 4; // Enter UAV Y Coordinate
            double height = 100;             // Enter height between UAV and UGV
            double Gimbal_Up_Down_Angle = 60; // Enter Gimbal angle
			
			// The UGV bearing angle is based on a regular X-Y Coordinate system meaning, East is 0 degrees
			// North is 90 degrees, West is 180 degrees, and South is 270 degrees
            double UGV_Bearing_Angle = 0;         // Enter UGV bearing angle 
            double Gimbal_Left_Right_Angle = 120; // Enter angle of Gimbal in relation to the UGV

			// Gets the angle of the UAV in relation to the UGV
            double Absolute_Angle = (UGV_Bearing_Angle + Gimbal_Left_Right_Angle) % 360;

			// Gets the distance between the UAV and UGV
            double Distance = (height / Math.Tan(Gimbal_Up_Down_Angle * (Math.PI / 180)));

			// Gets the X and Y components between the UAV and UGV
            double UGV_X_Component = Distance * Math.Cos(Absolute_Angle * (Math.PI / 180));
            double UGV_Y_Component = Distance * Math.Sin(Absolute_Angle * (Math.PI / 180));

			// Gets the X and Y GPS Coordinates
            double UGV_X_GPS_Coordinate = UAV_X_GPS_Coordinate - UGV_X_Component;
            double UGV_Y_GPS_Coordinate = UAV_Y_GPS_Coordinate - UGV_Y_Component;

			// Outputs the X and Y GPS Coordinates
            Console.WriteLine("UGV Coordinates ({0}, {1})", UGV_X_GPS_Coordinate, UGV_Y_GPS_Coordinate);



        }
    }
}
