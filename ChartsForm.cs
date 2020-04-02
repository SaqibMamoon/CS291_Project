using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class ChartsForm : Form
    {
        public struct cSBool
        {
            public cSBool (bool B, string S)
            {
                b = B; s = S;
            }
            public bool b;
            public string s;
        }

        public struct recursiveTool
        {
            public recursiveTool(int C=0, string D="")
            {
                count = C;
                direction = D;
            }
            public int count;
            public string direction;
        }

        DateTime startDate, endDate;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;
        BindingSource bindingSource;
        cSBool b1 = new cSBool(false, "colors"), b2 = new cSBool(false, "doors"), b3 = new cSBool(false, "style"),
            b4 = new cSBool(false, "age"), b5 = new cSBool(false, "sun_roof"), b6 = new cSBool(false, "fuelType"),
            b7 = new cSBool(false, "daily_price"), b8 = new cSBool(false, "weekly_price"), b9 = new cSBool(false, "monthly_price"),
            b10 = new cSBool(false, "heatedSeat"), b11 = new cSBool(false, "stereoQual"), b12 = new cSBool(false, "manual"), b13 = new cSBool(false, "cylinders"),
            b14 = new cSBool(false, "power_seats"), b15 = new cSBool(false, "bluetooth"), b16 = new cSBool(false, "model");

        private Dictionary<string, cSBool> buts = new Dictionary<string, cSBool>(); 

        public ChartsForm()
        {
            InitializeComponent();

            // Define path and DataDirectory to access the database later
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            label1.Text = "Start Date";
            label2.Text = "End Date";
            
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 4;
            chart1.ChartAreas[0].AxisY.Maximum = 500;

            button1.BackColor = Color.Red; button1.ForeColor = Color.White; button1.Text = "Colors"; button1.TabIndex = 1;buts.Add("b1", b1);
            button2.BackColor = Color.Red; button2.ForeColor = Color.White; button2.Text = "Doors"; button2.TabIndex = 2; buts.Add("b2", b2);
            button3.BackColor = Color.Red; button3.ForeColor = Color.White; button3.Text = "Style"; button3.TabIndex = 3; buts.Add("b3", b3);
            button4.BackColor = Color.Red; button4.ForeColor = Color.White; button4.Text = "Age"; button4.TabIndex = 4; buts.Add("b4", b4);
            button5.BackColor = Color.Red; button5.ForeColor = Color.White; button5.Text = "Sun Roof"; button5.TabIndex = 5; buts.Add("b5", b5);
            button6.BackColor = Color.Red; button6.ForeColor = Color.White; button6.Text = "Fuel type"; button6.TabIndex = 6; buts.Add("b6", b6);
            button7.BackColor = Color.Red; button7.ForeColor = Color.White; button7.Text = "Daily Prices"; button7.TabIndex = 7; buts.Add("b7", b7);
            button8.BackColor = Color.Red; button8.ForeColor = Color.White; button8.Text = "Weekly Prices"; button8.TabIndex = 8; buts.Add("b8", b8);
            button9.BackColor = Color.Red; button9.ForeColor = Color.White; button9.Text = "Monthly Prices"; button9.TabIndex = 9; buts.Add("b9", b9);
            button10.BackColor = Color.Red; button10.ForeColor = Color.White; button10.Text = "Heated Seats"; button10.TabIndex = 10; buts.Add("b10", b10);
            button11.BackColor = Color.Red; button11.ForeColor = Color.White; button11.Text = "Stereo Quality"; button11.TabIndex = 11; buts.Add("b11", b11);
            button12.BackColor = Color.Red; button12.ForeColor = Color.White; button12.Text = "Manual/Automatic"; button12.TabIndex = 12; buts.Add("b12", b12);
            button13.BackColor = Color.Red; button13.ForeColor = Color.White; button13.Text = "Cylinders in Engine"; button13.TabIndex = 13; buts.Add("b13", b13);
            button14.BackColor = Color.Red; button14.ForeColor = Color.White; button14.Text = "Power Seats"; button14.TabIndex = 14; buts.Add("b14", b14);
            button15.BackColor = Color.Red; button15.ForeColor = Color.White; button15.Text = "Blue Tooth"; button15.TabIndex = 15; buts.Add("b15", b15);
            button16.BackColor = Color.Red; button16.ForeColor = Color.White; button16.Text = "Models"; button16.TabIndex = 16; buts.Add("b16", b16);
            
            startDate = DateTime.Now; endDate = DateTime.Now;

            //This is to initialize the graph as reading everything.
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT count (*) from car_type", conn);
                int carInv = Convert.ToInt32(comm.ExecuteScalar());
                comm = new SqlCommand("SELECT count (*) from rental", conn);
                int carRent = Convert.ToInt32(comm.ExecuteScalar());
                chart1.Titles.Add("Total Cars");
                chart1.Series["Series1"].Points.AddXY("Total Cars in Inventory", carInv.ToString()); //This is how you add both X and Y values simultaneously
                chart1.Series["Series1"].Points.AddXY("Total Cars rented", carRent.ToString());
                chart1.AlignDataPointsByAxisLabel();
                conn.Close();
            }
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
            setRGTF(b1, button1, "b1");
        }

        private void b2C(object sender, EventArgs e)
        {
            setRGTF(b2, button2, "b2");
        }
        private void b3C(object sender, EventArgs e)
        {
            setRGTF(b3, button3, "b3");
        }
        private void b4C(object sender, EventArgs e)
        {
            setRGTF(b4, button4, "b4");
        }
        private void b5C(object sender, EventArgs e)
        {
            setRGTF(b5, button5, "b5");
        }
        private void b6C(object sender, EventArgs e)
        {
            setRGTF(b6, button6, "b6");
        }
        private void b7C(object sender, EventArgs e)
        {
            setRGTF(b7, button7, "b7");
        }
        private void b8C(object sender, EventArgs e)
        {
            setRGTF(b9, button8, "b8");
        }
        private void b9C(object sender, EventArgs e)
        {
            setRGTF(b9, button9, "b9");
        }
        private void b10C(object sender, EventArgs e)
        {
            setRGTF(b10, button10, "b10");
        }
        private void b11C(object sender, EventArgs e)
        {
            setRGTF(b11, button11, "b11");
        }
        private void b12C(object sender, EventArgs e)
        {
            setRGTF(b12, button12, "b12");
        }
        private void b13C(object sender, EventArgs e)
        {
            setRGTF(b13, button13, "b13");
        }
        private void b14C(object sender, EventArgs e)
        {
            setRGTF(b14, button14, "b14");
        }
        private void b15C(object sender, EventArgs e)
        {
            setRGTF(b15, button15, "b15");
        }
        private void b16C(object sender, EventArgs e)
        {
            setRGTF(b16, button16, "b16");
        }
        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void setRGTF(cSBool c, Button b, string key)
        {
            if (buts[key].b)
            {
                b.BackColor = Color.Red;
                c.b = false;
                buts[key] = c;
            }
            else
            {
                b.BackColor = Color.Green;
                c.b = true;
                buts[key] = c;
            }
            this.updateChart();
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
        private void updateChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            List<List<string>> store = new List<List<string>>();

            //This is where I'm going through the dictionary for each of the selected choices to make the query
            foreach (KeyValuePair<string, cSBool> entry in buts)
            {
                if (entry.Value.b)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                    {
                        conn.Open();
                        string command = "SELECT DISTINCT " + entry.Value.s + " FROM car, car_type, pricing_model " +
                            "WHERE car.type_id = car_type.type_id AND car_type.pricing_id = pricing_model.pricing_id";
                        SqlCommand comm = new SqlCommand(command, conn);
                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            List<string> temp = new List<string>();
                            while (reader.Read())
                            {
                                foreach (var read in reader)
                                {
                                    temp.Add(" AND " + read.ToString() + " = " + entry.Value.s);
                                }
                            }
                            store.Add(temp);
                        }
                        conn.Close();
                    }
                }
            }
            int paths = 1;
            foreach(List<string> ss in store)
            {
                paths *= ss.Count;
            }
            List<recursiveTool> toolsInv = new List<recursiveTool>();
            List<recursiveTool> toolsRen = new List<recursiveTool>();
            for (int i=0; i < paths; i++)
            {
                recursiveTool tool = new recursiveTool();
                toolsInv.Add(tool);
                toolsRen.Add(tool);
            }

            try
            {
                toolsInv = this.recurQuery(store.Count, store, toolsInv, "car, car_type, pricing_model WHERE car.car_id = car_type.car_id and car_type.pricing_id = pricing_model.pricing_id");
                toolsRen = this.recurQuery(store.Count, store, toolsInv, "car, car_type, pricing_model, rental WHERE rental.car_id = car.car_id and car.car_id = car_type.car_id and car_type.pricing_id = pricing_model.pricing_id");
            }
            catch
            {
                chart1.Series["Series1"].Points.AddXY("Empty search criteria", 0);
            }

            foreach (recursiveTool tool in toolsInv)
            {
                chart1.Series["Series1"].Points.AddXY(tool.direction, tool.count);
            }
            foreach(recursiveTool tool in toolsRen)
            {
                chart1.Series["Series1"].Points.AddXY(tool.direction, tool.count);
            }
        }

        private List<recursiveTool> recurQuery(int n, List<List<string>> vs, List<recursiveTool> recursiveTools, string fromWhere)
        {
            if (n == 0)
            {
                //Goes through each item
                for(int i=0; i < vs[n].Count; i++)
                {
                    //Goes through each portion of recursive tools to put the item into
                    for (int j=0; j < recursiveTools.Count / vs[n].Count; j++)
                    {
                        recursiveTool temp = recursiveTools[(i * recursiveTools.Count / vs[n].Count) + j];
                        temp.direction += vs[n][i];

                        using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                        {
                            conn.Open();
                            string command = "SELECT count (*) FROM" + fromWhere + temp;
                            SqlCommand comm = new SqlCommand(command, conn);
                            temp.count = Convert.ToInt32(comm.ExecuteScalar());
                            conn.Close();
                        }
                        recursiveTools[(i * recursiveTools.Count / vs[n].Count) + j] = temp;
                    }
                }
                return recursiveTools;
            }

            else
            {
                //Goes through each item
                int cnt = vs[n].Count;
                for (int i = 0; i < vs[n].Count; i++)
                {
                    //Goes through each portion of recursive tools to put the item into
                    for (int j = 0; j < recursiveTools.Count / vs[n].Count; j++)
                    {
                        recursiveTool temp = recursiveTools[(i * recursiveTools.Count / vs[n].Count) + j];
                        temp.direction += vs[n][i];
                        recursiveTools[(i * recursiveTools.Count / vs[n].Count) + j] = temp;
                    }
                }
                return recurQuery(n - 1, vs, recursiveTools, fromWhere);
            }
        }
    }
}