namespace CS291_Project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Reports = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Reports.SuspendLayout();
            this.tabCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.tabEmployee);
            this.Reports.Controls.Add(this.tabCustomer);
            this.Reports.Controls.Add(this.tabCharts);
            this.Reports.Location = new System.Drawing.Point(17, 16);
            this.Reports.Margin = new System.Windows.Forms.Padding(4);
            this.Reports.Name = "Reports";
            this.Reports.SelectedIndex = 0;
            this.Reports.Size = new System.Drawing.Size(1033, 523);
            this.Reports.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.tabEmployee.Size = new System.Drawing.Size(1025, 494);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.tabCustomer.Size = new System.Drawing.Size(1025, 494);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.button12);
            this.tabCharts.Controls.Add(this.button11);
            this.tabCharts.Controls.Add(this.button10);
            this.tabCharts.Controls.Add(this.button9);
            this.tabCharts.Controls.Add(this.button8);
            this.tabCharts.Controls.Add(this.button7);
            this.tabCharts.Controls.Add(this.button6);
            this.tabCharts.Controls.Add(this.button5);
            this.tabCharts.Controls.Add(this.button4);
            this.tabCharts.Controls.Add(this.button3);
            this.tabCharts.Controls.Add(this.button2);
            this.tabCharts.Controls.Add(this.button1);
            this.tabCharts.Controls.Add(this.label2);
            this.tabCharts.Controls.Add(this.label1);
            this.tabCharts.Controls.Add(this.dateTimePicker3);
            this.tabCharts.Controls.Add(this.dateTimePicker2);
            this.tabCharts.Controls.Add(this.chart1);
            this.tabCharts.Location = new System.Drawing.Point(4, 25);
            this.tabCharts.Margin = new System.Windows.Forms.Padding(4);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Padding = new System.Windows.Forms.Padding(4);
            this.tabCharts.Size = new System.Drawing.Size(1025, 494);
            this.tabCharts.TabIndex = 2;
            this.tabCharts.Text = "Charts";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(127, 99);
            this.dateTimePicker3.Name = "dateTimePicker1";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 5;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(127, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(333, 21);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(667, 463);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(46, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(281, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(46, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(281, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(46, 345);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(281, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(46, 374);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(281, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(46, 403);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(281, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(46, 432);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(281, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(46, 461);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(281, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 543);
            this.Controls.Add(this.Reports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MEK";
            this.Reports.ResumeLayout(false);
            this.tabCharts.ResumeLayout(false);
            this.tabCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl Reports;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

