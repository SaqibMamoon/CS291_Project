using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class ChartsForm : Form
    {

        DateTime startDate, endDate;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;

        public ChartsForm()
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
            button13.Text = "";
            startDate = DateTime.Now; endDate = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.startDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.endDate = dateTimePicker2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

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

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=C:\\Users\\PC\\Source\\Repos\\efirdc\\CS291_Project\\Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                connection.Open();
                
                adapter = new SqlDataAdapter("select * from " + tablesComboBox.Text, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableDataGridView.DataSource = dataTable;

                connection.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
