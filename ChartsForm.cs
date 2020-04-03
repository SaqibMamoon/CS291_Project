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
            public cSBool (bool B, string S, Button but)
            {
                b = B; s = S; button = but;
            }
            public bool b;
            public string s;
            public Button button;
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
            chart1.ChartAreas[0].AxisY.Maximum = 50;

            cSBool b1 = new cSBool(false, "colors", button1), b2 = new cSBool(false, "doors", button2), b3 = new cSBool(false, "style", button3),
            b4 = new cSBool(false, "age", button4), b5 = new cSBool(false, "sun_roof", button5), b6 = new cSBool(false, "fuelType", button6),
            b7 = new cSBool(false, "daily_price", button7), b8 = new cSBool(false, "weekly_price", button8), b9 = new cSBool(false, "monthly_price", button9),
            b10 = new cSBool(false, "heatedSeat", button10), b11 = new cSBool(false, "stereoQual", button11), b12 = new cSBool(false, "manual", button12), b13 = new cSBool(false, "cylinders", button13),
            b14 = new cSBool(false, "power_seats", button14), b15 = new cSBool(false, "bluetooth", button15), b16 = new cSBool(false, "model", button16),
            b17 = new cSBool(false, "pickup_branch_id", button17), b18 = new cSBool(false, "customer_id", button18), b19 = new cSBool(false, "car_id", button19), b20 = new cSBool(false, "employee_id", button20);


            b1.button.BackColor = Color.Red; b1.button.ForeColor = Color.White; b1.button.Text = "Colors"; b1.button.TabIndex = 1;buts.Add("b1", b1);
            b2.button.BackColor = Color.Red; b2.button.ForeColor = Color.White; b2.button.Text = "Doors"; b2.button.TabIndex = 2; buts.Add("b2", b2);
            b3.button.BackColor = Color.Red; b3.button.ForeColor = Color.White; b3.button.Text = "Style"; b3.button.TabIndex = 3; buts.Add("b3", b3);
            b4.button.BackColor = Color.Red; b4.button.ForeColor = Color.White; b4.button.Text = "Age"; b4.button.TabIndex = 4; buts.Add("b4", b4);
            b5.button.BackColor = Color.Red; b5.button.ForeColor = Color.White; b5.button.Text = "Sun Roof"; b5.button.TabIndex = 5; buts.Add("b5", b5);
            b6.button.BackColor = Color.Red; b6.button.ForeColor = Color.White; b6.button.Text = "Fuel type"; b6.button.TabIndex = 6; buts.Add("b6", b6);
            b7.button.BackColor = Color.Red; b7.button.ForeColor = Color.White; b7.button.Text = "Daily Prices"; b7.button.TabIndex = 7; buts.Add("b7", b7);
            b8.button.BackColor = Color.Red; b8.button.ForeColor = Color.White; b8.button.Text = "Weekly Prices"; b8.button.TabIndex = 8; buts.Add("b8", b8);
            b9.button.BackColor = Color.Red; b9.button.ForeColor = Color.White; b9.button.Text = "Monthly Prices"; b9.button.TabIndex = 9; buts.Add("b9", b9);
            b10.button.BackColor = Color.Red; b10.button.ForeColor = Color.White; b10.button.Text = "Heated Seats"; b10.button.TabIndex = 10; buts.Add("b10", b10);
            b11.button.BackColor = Color.Red; b11.button.ForeColor = Color.White; b11.button.Text = "Stereo Quality"; b11.button.TabIndex = 11; buts.Add("b11", b11);
            b12.button.BackColor = Color.Red; b12.button.ForeColor = Color.White; b12.button.Text = "Manual/Automatic"; b12.button.TabIndex = 12; buts.Add("b12", b12);
            b13.button.BackColor = Color.Red; b13.button.ForeColor = Color.White; b13.button.Text = "Cylinders in Engine"; b13.button.TabIndex = 13; buts.Add("b13", b13);
            b14.button.BackColor = Color.Red; b14.button.ForeColor = Color.White; b14.button.Text = "Power Seats"; b14.button.TabIndex = 14; buts.Add("b14", b14);
            b15.button.BackColor = Color.Red; b15.button.ForeColor = Color.White; b15.button.Text = "Blue Tooth"; b15.button.TabIndex = 15; buts.Add("b15", b15);
            b16.button.BackColor = Color.Red; b16.button.ForeColor = Color.White; b16.button.Text = "Models"; b16.button.TabIndex = 16; buts.Add("b16", b16);
            b17.button.BackColor = Color.Red; b17.button.ForeColor = Color.White; b17.button.Text = "Sales/Branch"; b17.button.TabIndex = 17; buts.Add("b17", b17); //Here we do groupby branch_id, count (*) with a select for both
            b18.button.BackColor = Color.Red; b18.button.ForeColor = Color.White; b18.button.Text = "Customers/Branch"; b18.button.TabIndex = 18; buts.Add("b18", b18); //Here we do group by branch_id, customer_id and then another groupby branch_id, count(*) for the number of unique customers 
            b19.button.BackColor = Color.Red; b19.button.ForeColor = Color.White; b19.button.Text = "Cars/Branch"; b19.button.TabIndex = 19; buts.Add("b19", b19); //Here we do a simple if branch.branch_id = car.branch_id with select branch.name, count (*)
            b20.button.BackColor = Color.Red; b20.button.ForeColor = Color.White; b20.button.Text = "Employees/branch"; b20.button.TabIndex = 20; buts.Add("b20", b20); //Here we do branch.branch_id = employee.branch_id, SELECT branch.name, count(*)

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
        private void startTimeChange(object s, EventArgs e)
        {
            this.startDate = dateTimePicker1.Value;
        }
        private void endTimeChanged(object s, EventArgs e)
        {
            this.endDate = dateTimePicker2.Value;
        }
        private void b1C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b1"], buts["b1"].button, "b1");
        }

        private void b2C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b2"], buts["b2"].button, "b2");
        }
        private void b3C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b3"], buts["b3"].button, "b3");
        }
        private void b4C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b4"], buts["b4"].button, "b4");
        }
        private void b5C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b5"], buts["b5"].button, "b5");
        }
        private void b6C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b6"], buts["b6"].button, "b6");
        }
        private void b7C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b7"], buts["b7"].button, "b7");
        }
        private void b8C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b8"], buts["b8"].button, "b8");
        }
        private void b9C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b9"], buts["b9"].button, "b9");
        }
        private void b10C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b10"], buts["b10"].button, "b10");
        }
        private void b11C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b11"], buts["b11"].button, "b11");
        }
        private void b12C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b12"], buts["b12"].button, "b12");
        }
        private void b13C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b13"], buts["b13"].button, "b13");
        }
        private void b14C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b14"], buts["b14"].button, "b14");
        }
        private void b15C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b15"], buts["b15"].button, "b15");
        }
        private void b16C(object sender, EventArgs e)
        {
            carChartUpdate(buts["b16"], buts["b16"].button, "b16");
        }
        private void b17C(object sender, EventArgs e)
        {
            customerChartUpdate(buts["b17"], buts["b17"].button, "b17");
            choice17();
        }
        private void b18C(object sender, EventArgs e)
        {
            customerChartUpdate(buts["b18"], buts["b18"].button, "b18");
            choice18();
        }
        private void b19C(object sender, EventArgs e)
        {
            customerChartUpdate(buts["b19"], buts["b19"].button, "b19");
            choice19();
        }
        private void b20C(object sender, EventArgs e)
        {
            customerChartUpdate(buts["b20"], buts["b20"].button, "b20");
            choice20();
        }
        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void carChartUpdate(cSBool c, Button b, string key)
        {
            string k;
            for (int i = 17; i < 21; i++)
            {
                k = "b" + i.ToString();
                if (buts[k].b)
                {
                    buts[k].button.BackColor = Color.Red;
                    cSBool cb = buts[k];
                    cb.b = false;
                    buts[k] = cb;
                }
            }

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
            this.updateChartCars();
        }

        private void customerChartUpdate(cSBool c, Button b, string key)
        {
            string k;
            chart1.Series.Clear();
            chart1.Series.Add("Series1");

            //Just resets all look ups for car transactions to none-existent
            for (int i = 1; i < 21; i++)
            {
                k = "b" + i.ToString();
                if (buts[k].b && k != key)
                {
                    buts[k].button.BackColor = Color.Red;
                    cSBool bb = buts[k];
                    bb.b = false;
                    buts[k] = bb;
                }
            }
            if (buts[key].b)
            {
                c.button.BackColor = Color.Red;
                c.b = false;
                buts[key] = c;
            }
            else
            {
                c.button.BackColor = Color.Green;
                c.b = true;
                buts[key] = c;
            }
        }

        private void choice17()
        {
            //Here we do groupby branch_id, count (*) with a select for both
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                conn.Open(); 
                SqlCommand comm = new SqlCommand("SELECT branch.name, count (*) FROM branch, rental WHERE branch.branch_id = rental.pickup_branch_id AND ((start_date BETWEEN @startD AND @endD) OR (end_date BETWEEN @startD AND @endD)) GROUP BY branch.branch_id, branch.name", conn);
                comm.Parameters.AddWithValue("@startD", startDate);
                comm.Parameters.AddWithValue("@endD", endDate);
                int columns=0, max=0;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    List<string> temp = new List<string>();
                    while (true)
                    {
                        try
                        {
                            int count; string name;
                            if (reader.Read())
                            {
                                name = reader[0].ToString();
                                count = (Int32)reader[1];
                                chart1.Series["Series1"].Points.AddXY(name, count);
                                columns++;
                                if (count > max)
                                {
                                    max = count+ 2;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                    }

                }

                chart1.ChartAreas[0].AxisX.Maximum = columns + 1;
                chart1.ChartAreas[0].AxisY.Maximum = max;
            }
        }
        private void choice18()
        {
            //Here we do group by branch_id, customer_id and then another groupby branch_id, count(*) for the number of unique customers 
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT branch.name, count (*) FROM branch, rental, customer WHERE branch.branch_id = rental.pickup_branch_id " +
                    "AND rental.customer_id = customer.customer_id " +
                    "AND ((start_date BETWEEN @startD AND @endD) OR (end_date BETWEEN @startD AND @endD)) GROUP BY branch.name", conn);
                comm.Parameters.AddWithValue("@startD", startDate);
                comm.Parameters.AddWithValue("@endD", endDate);
                int columns = 0, max = 0;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    List<string> temp = new List<string>();
                    while (true)
                    {
                        try
                        {
                            int count; string name;
                            if (reader.Read())
                            {
                                name = reader[0].ToString();
                                count = (Int32)reader[1];
                                chart1.Series["Series1"].Points.AddXY(name, count);
                                columns++;
                                if (count > max)
                                {
                                    max = count + 2;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                    }

                }

                chart1.ChartAreas[0].AxisX.Maximum = columns + 1;
                chart1.ChartAreas[0].AxisY.Maximum = max;
            }
        }
        private void choice19()
        {
            //Here we do a simple if branch.branch_id = car.branch_id with select branch.name, count (*)
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT branch.name, count (*) FROM branch, car WHERE branch.branch_id = car.branch_id group by branch.name",conn);
                int columns = 0, max = 0;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    List<string> temp = new List<string>();
                    while (true)
                    {
                        try
                        {
                            int count; string name;
                            if (reader.Read())
                            {
                                name = reader[0].ToString();
                                count = (Int32)reader[1];
                                chart1.Series["Series1"].Points.AddXY(name, count);
                                columns++;
                                if (count > max)
                                {
                                    max = count + 2;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                    }

                }

                chart1.ChartAreas[0].AxisX.Maximum = columns + 1;
                chart1.ChartAreas[0].AxisY.Maximum = max;
            }
        }
        private void choice20()
        {
            //Here we do branch.branch_id = employee.branch_id, SELECT branch.name, count(*)
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT branch.name, count (*) FROM branch, employee WHERE branch.branch_id = employee.branch_id GROUP BY branch.name", conn);
                int columns = 0, max = 0;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    List<string> temp = new List<string>();
                    while (true)
                    {
                        try
                        {
                            int count; string name;
                            if (reader.Read())
                            {
                                name = reader[0].ToString();
                                count = (Int32)reader[1];
                                chart1.Series["Series1"].Points.AddXY(name, count);
                                columns++;
                                if (count > max)
                                {
                                    max = count + 2;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                    }
                    conn.Close();

                }
                if (columns != 0)
                {
                    chart1.ChartAreas[0].AxisX.Maximum = columns + 1;
                    chart1.ChartAreas[0].AxisY.Maximum = max;
                }
                else
                {
                    using (SqlConnection connn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                    {
                        chart1.ChartAreas[0].AxisX.Maximum = 3;
                        connn.Open();
                        SqlCommand commm = new SqlCommand("SELECT count (*) from car_type", connn);
                        int carInv = Convert.ToInt32(commm.ExecuteScalar());
                        commm = new SqlCommand("SELECT count (*) from rental", connn);
                        int carRent = Convert.ToInt32(commm.ExecuteScalar());
                        chart1.Series["Series1"].Points.AddXY("Total Cars in Inventory", carInv.ToString()); //This is how you add both X and Y values simultaneously
                        chart1.Series["Series1"].Points.AddXY("Total Cars rented", carRent.ToString());
                        chart1.AlignDataPointsByAxisLabel();
                        connn.Close();
                    }
                }
            }
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
        private void updateChartCars()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            List<List<string>> store = new List<List<string>>();
            int count = 0;
            //This is where I'm going through the dictionary for each of the selected choices to make the query
            foreach (KeyValuePair<string, cSBool> entry in buts)
            {
                count++;
                if (count < 17)
                {
                    if (entry.Value.b)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                        "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                        "Integrated Security=True"))
                        {
                            conn.Open();
                            string command = "SELECT DISTINCT " + entry.Value.s + " FROM car_type, car, pricing_model";
                            SqlCommand comm = new SqlCommand(command, conn);

                            using (SqlDataReader reader = comm.ExecuteReader())
                            {
                                List<string> temp = new List<string>();
                                while (true)
                                {
                                    try
                                    {
                                        if (reader.Read())
                                        {
                                            temp.Add(" and " + entry.Value.s + " IN ('" + reader[0].ToString().Replace(" ", "") + "')");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        break;
                                    }
                                }
                                store.Add(temp);
                            }
                            conn.Close();
                        }
                    }
                }
            }
            
            int paths = 1;
            foreach(List<string> ss in store)
            {
                paths *= ss.Count;
            }
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = paths + 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum= 5;
            List<recursiveTool> toolsRen = new List<recursiveTool>();
            try
            {
                toolsRen = Query(store, "car, car_type, pricing_model, rental WHERE rental.car_id = car.car_id and car.type_id = car_type.type_id and car_type.pricing_id = pricing_model.pricing_id");
                //toolsRen = this.recurQuery(store.Count, store, toolsRen, "car, car_type, pricing_model, rental WHERE rental.car_id = car.car_id and car.type_id = car_type.type_id and car_type.pricing_id = pricing_model.pricing_id");
                foreach (recursiveTool tool in toolsRen)
                {
                    chart1.Series["Series1"].Points.AddXY(tool.direction, tool.count);
                }
            }
            catch
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                {
                    chart1.ChartAreas[0].AxisX.Maximum = 3;
                    conn.Open();
                    SqlCommand comm = new SqlCommand("SELECT count (*) from car_type", conn);
                    int carInv = Convert.ToInt32(comm.ExecuteScalar());
                    comm = new SqlCommand("SELECT count (*) from rental", conn);
                    int carRent = Convert.ToInt32(comm.ExecuteScalar());
                    chart1.Series["Series1"].Points.AddXY("Total Cars in Inventory", carInv.ToString()); //This is how you add both X and Y values simultaneously
                    chart1.Series["Series1"].Points.AddXY("Total Cars rented", carRent.ToString());
                    chart1.AlignDataPointsByAxisLabel();
                    conn.Close();
                }
            }
        }
        // 
        private List<recursiveTool> Query(List<List<string>> vs, string fromWhere)
        {
            List<recursiveTool> tools = new List<recursiveTool>();
            List<string> nm = vs[0];
            //This is the proper way to do it
            for (int i = 1; i < vs.Count; i++)
            {
                nm = cartesianProduct(nm, vs[i]);
            }
            foreach(string str in nm)
            {
                recursiveTool tool = new recursiveTool(0, str);
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                {
                    conn.Open();
                    string start = startDate.ToString("yyyy-MM-dd");
                    string end = endDate.ToString("yyyy-MM-dd");
                    System.Diagnostics.Debug.WriteLine(start);
                    string start_and_end_check = " AND ((start_date BETWEEN @startD AND @endD) OR (end_date BETWEEN @startD AND @endD))";
                    string command = "SELECT count (*) FROM " + fromWhere + str + start_and_end_check;
                    System.Diagnostics.Debug.WriteLine(command, "checker");
                    SqlCommand comm = new SqlCommand(command, conn);
                    comm.Parameters.AddWithValue("@startD", startDate.ToString("yyyy-MM-dd"));
                    comm.Parameters.AddWithValue("@endD", endDate.ToString("yyyy-MM-dd"));
                    tool.count = (Int32)comm.ExecuteScalar();
                    conn.Close();
                }
                tools.Add(tool);
            }
            return tools;
        }

        private List<string> cartesianProduct(List<string> a, List<string> b)
        {
            List<string> result = new List<string>();
            for(int i =0; i < a.Count ; i++)
            {
                for(int j=0; j < b.Count; j++)
                {
                    result.Add(a[i] + b[j]);
                }
            }
            return result;
        }
    }
}