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
        BindingSource bindingSource;
        bool but1, but2, but3, but4, but5, but6, but7, but8, but9, but10, but11, but12, but13;

        public ChartsForm()
        {
            InitializeComponent();

            // Define path and DataDirectory to access the database later
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

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
            
            button1.BackColor = Color.Red; but1 = false;
            button2.BackColor = Color.Red; but2 = false;
            button3.BackColor = Color.Red; but3 = false;
            button4.BackColor = Color.Red; but4 = false;
            button5.BackColor = Color.Red; but5 = false;
            button6.BackColor = Color.Red; but6 = false;
            button7.BackColor = Color.Red; but7 = false;
            button8.BackColor = Color.Red; but8 = false;
            button9.BackColor = Color.Red; but9 = false;
            button10.BackColor = Color.Red; but10 = false;
            button11.BackColor = Color.Red; but11 = false;
            button12.BackColor = Color.Red; but12 = false; 
            button13.BackColor = Color.Red; but13 = false;

            startDate = DateTime.Now; endDate = DateTime.Now;

            // Set the ComboBox to the first option by default
            tablesComboBox.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.startDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.endDate = dateTimePicker2.Value;
        }

        private void b1C(object sender, EventArgs e)
        {
            if (but1)
            {
                button1.BackColor = Color.Red;
                but1 = false;
            }
            else
            {
                button1.BackColor = Color.Green;
                but1 = true;
            }
        }

        private void b2C(object sender, EventArgs e)
        {
            if (but2)
            {
                button2.BackColor = Color.Red;
                but2 = false;
            }
            else
            {
                button2.BackColor = Color.Green;
                but2 = true;
            }
        }
        private void b3C(object sender, EventArgs e)
        {
            if (but3)
            {
                button3.BackColor = Color.Red;
                but3 = false;
            }
            else
            {
                button3.BackColor = Color.Green;
                but3 = true;
            }
        }
        private void b4C(object sender, EventArgs e)
        {
            if (but4)
            {
                button4.BackColor = Color.Red;
                but4 = false;
            }
            else
            {
                button4.BackColor = Color.Green;
                but4 = true;
            }
        }
        private void b5C(object sender, EventArgs e)
        {
            if (but5)
            {
                button5.BackColor = Color.Red;
                but5 = false;
            }
            else
            {
                button5.BackColor = Color.Green;
                but5 = true;
            }
        }
        private void b6C(object sender, EventArgs e)
        {
            if (but6)
            {
                button6.BackColor = Color.Red;
                but6 = false;
            }
            else
            {
                button6.BackColor = Color.Green;
                but6 = true;
            }
        }
        private void b7C(object sender, EventArgs e)
        {
            if (but7)
            {
                button7.BackColor = Color.Red;
                but7 = false;
            }
            else
            {
                button7.BackColor = Color.Green;
                but7 = true;
            }
        }
        private void b8C(object sender, EventArgs e)
        {
            if (but8)
            {
                button8.BackColor = Color.Red;
                but8 = false;
            }
            else
            {
                button8.BackColor = Color.Green;
                but8 = true;
            }
        }
        private void b9C(object sender, EventArgs e)
        {
            if (but9)
            {
                button9.BackColor = Color.Red;
                but9 = false;
            }
            else
            {
                button9.BackColor = Color.Green;
                but9 = true;
            }
        }
        private void b10C(object sender, EventArgs e)
        {
            if (but10)
            {
                button10.BackColor = Color.Red;
                but10 = false;
            }
            else
            {
                button10.BackColor = Color.Green;
                but10 = true;
            }
        }
        private void b11C(object sender, EventArgs e)
        {
            if (but11)
            {
                button11.BackColor = Color.Red;
                but11 = false;
            }
            else
            {
                button11.BackColor = Color.Green;
                but11 = true;
            }
        }
        private void b12C(object sender, EventArgs e)
        {
            if (but12)
            {
                button12.BackColor = Color.Red;
                but12 = false;
            }
            else
            {
                button12.BackColor = Color.Green;
                but12 = true;
            }
        }
        private void b13C(object sender, EventArgs e)
        {
            if (but13)
            {
                button13.BackColor = Color.Red;
                but13 = false;
            }
            else
            {
                button13.BackColor = Color.Green;
                but13 = true;
            }
        }
        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void clearTablesButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                connection.Open();

                for (int i = 0; i < tablesComboBox.Items.Count; i++)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "delete from " + tablesComboBox.Items[i].ToString();
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            updateTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm nU = new LoginForm();
            nU.ShowDialog();
            this.Close();
        }

        private void saveTableButton_Click(object sender, EventArgs e)
        {
            // ISSUE: Not clicking gold_star registers as NULL so it gives an error, after clicking one or more times the value is then valid even when 0.
            using (connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                try
                {
                    adapter = new SqlDataAdapter("select * from " + tablesComboBox.Text, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    DataTable changesDataTable = dataTable.GetChanges();
                    if (changesDataTable != null)
                    {
                        adapter.Update(changesDataTable);
                    }
                    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void updateTable()
        {
            using (connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                connection.Open();

                adapter = new SqlDataAdapter("select * from " + tablesComboBox.Text, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableDataGridView.DataSource = dataTable;
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                tableDataGridView.DataSource = bindingSource;

                connection.Close();
            }
        }
    }
}