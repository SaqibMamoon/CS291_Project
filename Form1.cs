using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS291_Project
{
	public partial class Form1 : Form
	{

		DateTime startDate, endDate;

		public Form1()
		{
			InitializeComponent();
			label1.Text = "Start Date";
			label2.Text = "End Date";
			button1.Text = "Per Branch Rented Cars";
			button2.Text = "Per Branch car rentals per type";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";
			button10.Text = "";
			button11.Text = "";
			button12.Text = "Predictions for future rentals";
			startDate = DateTime.Now; endDate = DateTime.Now;


		}
		/*Purpose: This sets start date*/
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			this.startDate = dateTimePicker3.Value;
		}
		/*Purpose: This sets end date*/
		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			this.endDate = dateTimePicker2.Value;
		}

		/*Purpose: This one tells the per branch rented cars*/
		private void button1_Click(object sender, EventArgs e)
		{

		}
		/*Purpose: This one will tell us car rentals per type*/
		private void button2_Click(object sender, EventArgs e)
		{

		}
		/*Purpose: */
		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button11_Click(object sender, EventArgs e)
		{

		}
		/*Purpose: Will tell future predictions for sales*/
		private void button12_Click(object sender, EventArgs e)
		{

		}
	}
}
