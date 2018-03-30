namespace UGV_Lidar_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start_label = new System.Windows.Forms.Label();
            this.StartStep_textBox = new System.Windows.Forms.TextBox();
            this.EndStep_textBox = new System.Windows.Forms.TextBox();
            this.End_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.dataDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "LidarData";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(642, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Start_label
            // 
            this.Start_label.AutoSize = true;
            this.Start_label.Location = new System.Drawing.Point(202, 488);
            this.Start_label.Name = "Start_label";
            this.Start_label.Size = new System.Drawing.Size(75, 17);
            this.Start_label.TabIndex = 2;
            this.Start_label.Text = "Start Step:";
            // 
            // StartStep_textBox
            // 
            this.StartStep_textBox.Location = new System.Drawing.Point(274, 483);
            this.StartStep_textBox.Name = "StartStep_textBox";
            this.StartStep_textBox.Size = new System.Drawing.Size(45, 22);
            this.StartStep_textBox.TabIndex = 3;
            this.StartStep_textBox.Text = "180";
            this.StartStep_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EndStep_textBox
            // 
            this.EndStep_textBox.Location = new System.Drawing.Point(274, 516);
            this.EndStep_textBox.Name = "EndStep_textBox";
            this.EndStep_textBox.Size = new System.Drawing.Size(45, 22);
            this.EndStep_textBox.TabIndex = 5;
            this.EndStep_textBox.Text = "900";
            this.EndStep_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // End_label
            // 
            this.End_label.AutoSize = true;
            this.End_label.Location = new System.Drawing.Point(202, 521);
            this.End_label.Name = "End_label";
            this.End_label.Size = new System.Drawing.Size(70, 17);
            this.End_label.TabIndex = 4;
            this.End_label.Text = "End Step:";
            // 
            // refresh_button
            // 
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.refresh_button.Location = new System.Drawing.Point(366, 480);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(171, 58);
            this.refresh_button.TabIndex = 6;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(719, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "LidarData";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(636, 426);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(1155, 480);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(123, 58);
            this.saveDataButton.TabIndex = 8;
            this.saveDataButton.Text = "Save Data";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // dataDescriptionTextBox
            // 
            this.dataDescriptionTextBox.Location = new System.Drawing.Point(818, 516);
            this.dataDescriptionTextBox.Name = "dataDescriptionTextBox";
            this.dataDescriptionTextBox.Size = new System.Drawing.Size(318, 22);
            this.dataDescriptionTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description of Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDescriptionTextBox);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.EndStep_textBox);
            this.Controls.Add(this.End_label);
            this.Controls.Add(this.StartStep_textBox);
            this.Controls.Add(this.Start_label);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Start_label;
        private System.Windows.Forms.TextBox StartStep_textBox;
        private System.Windows.Forms.TextBox EndStep_textBox;
        private System.Windows.Forms.Label End_label;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.TextBox dataDescriptionTextBox;
        private System.Windows.Forms.Label label1;
    }
}

