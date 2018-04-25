using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using SCIP_library;
using System.Runtime.InteropServices;


namespace UGV_Lidar_chart
{
    public partial class Form1 : Form
    {

        int fileIndex = 0;
        int start_step;
        int end_step;

        Random randomNum = new Random();
        private List<long> distances = new List<long>(50);

        public Form1()
        {
            AllocConsole();
            InitializeComponent();

            chart1.Series["LidarData"].ChartType = SeriesChartType.Polar;
            chart1.Series["LidarData"].Color = Color.Red;

            chart2.Series["LidarData"].ChartType = SeriesChartType.RangeColumn;
            chart2.Series["LidarData"].Color = Color.Red;

            ChartArea ca = chart1.ChartAreas[0];
            Axis ax = ca.AxisX;
            Axis ay = ca.AxisY;

            ax.Minimum = start_step;
            ax.Maximum = end_step;
            ax.Interval = 15;   // 15° interval
            ax.Crossing = -270;    // start the segments at the top!

            //refresh_button.Click += build_graph;
            Application.Idle += build_graph;
        }

        void build_graph(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            const int GET_NUM = 10;
            start_step = int.Parse(StartStep_textBox.Text); // 0 degrees. Consider getting info from a text box
            end_step = int.Parse(EndStep_textBox.Text);// 180 degrees. Consider getting info from a text box

            try
            {
                string port_name = "COM4";
                int baudrate = 9600;

                SerialPort urg = new SerialPort(port_name, baudrate);
                urg.NewLine = "\n\n";

                urg.Open();

                urg.Write(SCIP_Writer.SCIP2());
                urg.ReadLine(); // ignore echo back
                urg.Write(SCIP_Writer.MD(start_step, end_step));
                urg.ReadLine(); // ignore echo back

                //List<long> distances = new List<long>();
                long time_stamp = 0;
                for (int i = 0; i < GET_NUM; ++i)
                {
                    Console.WriteLine("test for loop");
                    string receive_data = urg.ReadLine();
                    if (SCIP_Reader.MD(receive_data, ref time_stamp, ref distances))
                    {
                        Console.WriteLine(receive_data);
                        break;
                    }
                    if (distances.Count == 0)
                    {
                        Console.WriteLine(receive_data);
                        continue;
                    }
                    // show distance data
                    //Send the distances List to the form graph object
                }

                urg.Write(SCIP_Writer.QT()); // stop measurement mode
                urg.ReadLine(); // ignore echo back
                urg.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                chart1.Series["LidarData"].Points.Clear();
                chart2.Series["LidarData"].Points.Clear();
                //distances.Clear();
                //for (int i = 0; i < 180; i++)
                //{
                //    distances.Add(randomNum.Next(50, 60));

                //}

                for (int i = 0; i < distances.Count; i++)
                {

                        chart1.Series["LidarData"].Points.AddXY(i, distances[i]);
                        chart2.Series["LidarData"].Points.AddXY(i, distances[i]);

                }
            }



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }




        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            string Output1 = string.Join(" ", distances);
            //System.IO.File.WriteAllText(@"C:\Users\Troy\Desktop\lidarFileTest.txt", Output1);
            System.IO.File.AppendAllText(@"C:\Users\Troy\Desktop\lidarFileTest.txt", "      Test Index " + fileIndex + ": " + dataDescriptionTextBox.Text +"       ");
            System.IO.File.AppendAllText(@"C:\Users\Troy\Desktop\lidarFileTest.txt", Output1);

            fileIndex++;
        }
    }
}


