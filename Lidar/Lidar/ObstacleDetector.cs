using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObstacleDetection
{
    class ObstacleDetector
    {
        private List<double> stepDistances;
        private List<Vector2d> vectors;
        private int startStep;

        //Objects that are farther than the MAX_DISTANCE
        //Will not be considered when forming an obstacle 
        private double maxDistance;

        public ObstacleDetector(int startingStep, List<double> distanceList, double maxDistance)
        {
            this.maxDistance = maxDistance;
            stepDistances = distanceList;
            startStep = startingStep;
            vectors = new List<Vector2d>();
        }

        /**
        * Takes a list of distance vectors and creates
        * calculates the vectorSum 
        **/
        public VectorSum getVectorSum()
        {
            //vector solution
            /*
            Vector2d sum = new Vector2d(0, 0);
            int count = 0;
            int step;
            for (int i = 0; i < stepDistances.Count; i++)
            {
                step = i + startStep;

                //Ignore Data that is greater than maxDistance or is infinity
                if (stepDistances[i] * 0.001 <= maxDistance && stepDistances[i] != 1)
                {
                    double magnitude = stepDistances[i] * .001;
                    double angle = stepToRadians(step);
                    Vector2d newVector = new Vector2d(1 / magnitude, angle);

                    sum += newVector;
                    count++;
                }

            }
            return new VectorSum(count, sum.getAngle(), sum.getMagnitude());*/

            //TODO: add median filter too reduce noise and complexity.
            //http://ieeexplore.ieee.org/xpls/icp.jsp?arnumber=7279550

            //Case based solution
            int count = 0;
            int step;
            bool front = false;
            bool left = false;
            bool right = false;
            double closestLeft = maxDistance;
            double closestRight = maxDistance;
            double closestFront  = maxDistance;


            for (int i = 0; i < stepDistances.Count; i++)
            {
                step = i + startStep;
                //Ignore Data that is greater than maxDistance or is infinity
                if (stepDistances[i] * 0.001 <= maxDistance && stepDistances[i] != 1 && stepDistances[i] >= 200)
                {
                    double magnitude = stepDistances[i] * .001;
                    double angle = stepToRadians(step);
                    if (angle > -45 * Math.PI / 180 && angle < 45 * Math.PI / 180)
                    {
                        front = true;
                        if (closestFront > magnitude)
                            closestFront = magnitude;
                    }

                    else if (angle < -45 * Math.PI / 180 && angle > -100 * Math.PI / 180)
                    {
                        right = true;
                        if (closestRight > magnitude)
                            closestRight = magnitude;
                    }
                    else if (angle > 45 * Math.PI / 180 && angle < 100 * Math.PI / 180)
                    {
                        left = true;
                        if (closestLeft > magnitude)
                            closestLeft = magnitude;
                    }
                    count++;
                    
                }
            }
            if (front && left && right)
                return new VectorSum(count, 0, 1 / Math.Min(closestFront, Math.Min(closestLeft, closestRight)));
            else if (front && left)
                return new VectorSum(count, 45 * Math.PI / 180, 1 / Math.Min(closestFront, closestLeft));
            else if (front && right)
                return new VectorSum(count, -45 * Math.PI / 180, 1 / Math.Min(closestFront, closestRight));
            else if (left && right)
                return new VectorSum(count, 180 * Math.PI / 180, 1 / Math.Min(closestLeft, closestRight));
            else if (left)
                return new VectorSum(count, 90 * Math.PI / 180, 1 / closestLeft);
            else if (right)
                return new VectorSum(count, -90 * Math.PI / 180, 1 / closestRight);
            else if (front)
                return new VectorSum(count, 0, 1 / closestFront);
            else
                return new VectorSum(count, 180 * Math.PI / 180, 0);
        }

        //Set the max distance in milimieters
        public void setMaxDistance(double newMax)
        {
            maxDistance = newMax;
        }

        /**
        * Converts a step from the lidar into a degree.
        * Note that each step on the the Hokuyo UTM-30LX lidar
        * is separated by .25 degrees. The lidar has a 270 degree
        * range of detection. Step 0 occurs at angle 225 degrees.  
        **/
        private double stepToRadians(int step)
        {
            double startAngle = 225;
            double angle = startAngle + step * .25f;
            if (angle >= 360)
            {
                angle = angle - 360;
            }
            angle *= Math.PI / 180;
            if (angle > Math.PI)
                angle -= Math.PI * 2;
            return angle;
        }
    }
}
