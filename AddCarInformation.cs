using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class AddCarInformation : Form
    {
        public AddCarInformation()
        {
            InitializeComponent();
            tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            PopulateAddCarComboBoxes();
        }

        private void addPricingModelButton_Click(object sender, EventArgs e)
        {
            if (pricingModelNameTextBox.TextLength <= 0)
            {
                pricingModelErrorLabel.Visible = true;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = "insert into pricing_model (model_name, daily_price, weekly_price, monthly_price) " +
                                          "values (@model_name, @daily_price, @weekly_price, @monthly_price);";
                    command.Parameters.AddWithValue("@model_name", pricingModelNameTextBox.Text);
                    command.Parameters.AddWithValue("@daily_price", dailyNumericUpDown.Value);
                    command.Parameters.AddWithValue("@weekly_price", weeklyNumericUpDown.Value);
                    command.Parameters.AddWithValue("@monthly_price", monthlyNumericUpDown.Value);
                    int returned = command.ExecuteNonQuery();
                    if (returned == 1)
                    {
                        MessageBox.Show("Car type has been added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Car type failed to be not added.");
                    }

                    connection.Close();
                }
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            string errorText = "";
            carErrorLabel.Text = errorText;
            var carIDIsNumeric = int.TryParse(carIDTextBox.Text, out int n);
            if (carIDTextBox.Text == "" || !carIDIsNumeric)
            {
                errorText += "Input a valid car ID.\n";
            }
            if (branchComboBox.SelectedItem == null)
            {
                errorText += "Select a branch.\n";
            }
            if (carTypeComboBox.SelectedItem == null)
            {
                errorText += "Select a car type.\n";
            }
            if (errorText != "")
            {
                carErrorLabel.Text = errorText;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = "select count(*) from car " +
                                          "where (car.car_id = @carID)";
                    command.Parameters.AddWithValue("@carID", carIDTextBox.Text);
                    int carExists = Convert.ToInt32(command.ExecuteScalar());
                    if (carExists == 1)
                    {
                        carErrorLabel.Text = "Car ID already exists.";
                        return;
                    }


                    command.CommandText = "insert into car (car_id, type_id, branch_id) " +
                                          "values (@car_id, @type_id, @branch_id);";
                    command.Parameters.AddWithValue("@car_id", pricingModelComboBox.Text);
                    int typeID = Int32.Parse(Regex.Match(carTypeComboBox.Text, @"\d+").Value);
                    command.Parameters.AddWithValue("@type_id", typeID);
                    int branchID = Int32.Parse(Regex.Match(branchComboBox.Text, @"\d+").Value);
                    command.Parameters.AddWithValue("@branch_id", branchID);
                    int returned = command.ExecuteNonQuery();
                    if (returned == 1)
                    {
                        MessageBox.Show("Car type has been added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Car type failed to be not added.");
                    }

                    connection.Close();
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            carTypeComboBox.Items.Clear();
            branchComboBox.Items.Clear();
            if (tabControl.SelectedTab == carTabPage)
            {
                PopulateAddCarComboBoxes();
            }
            else if (tabControl.SelectedTab == carTypeTabPage)
            {
                pricingModelComboBox.Items.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = "select * from pricing_model";
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string customerInformation = dataReader[0] + ", " + dataReader[1] + ", " + dataReader[2] + ", " + dataReader[3] + ", " + dataReader[4];
                        pricingModelComboBox.Items.Add(Regex.Replace(customerInformation, @"\s\s+", " "));
                    }
                    dataReader.Close();

                    connection.Close();
                }
            }

        }

        private void PopulateAddCarComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "select * from branch";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string customerInformation = dataReader[0] + ", " + dataReader[1];
                    branchComboBox.Items.Add(Regex.Replace(customerInformation, @"\s\s+", " "));
                }
                dataReader.Close();

                command.CommandText = "select * from car_type";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string customerInformation = dataReader[0] + ", " + dataReader[1] + ", " + dataReader[2];
                    carTypeComboBox.Items.Add(Regex.Replace(customerInformation, @"\s\s+", " "));
                }
                dataReader.Close();

                connection.Close();
            }
        }

        private void addCarTypeButton_Click(object sender, EventArgs e)
        {
            string errorText = "";
            carTypeErrorLabel.Text = errorText;
            if (!CarTypeTextBoxesFilled())
            {
                errorText += "You must fill in all the textboxes\n";
            }
            if (pricingModelComboBox.SelectedItem == null)
            {
                errorText += "You must select a pricing model\n";
            }
            if (errorText != "")
            {
                carTypeErrorLabel.Text = errorText;
                return;
            }
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                        "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                        "Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = "insert into car_type (manufacturer, model, seats, doors, colors, heatedSeat, age, condition, sun_roof, bluetooth, manual, fuelType, pricing_id) " +
                                          "values (@manufacturer, @model, @seats, @doors, @colors, @heatedSeat, @age, @condition, @sun_roof, @bluetooth, @manual, @fuelType, @pricing_id);";
                    command.Parameters.AddWithValue("@manufacturer", manufacturerTextBox.Text);
                    command.Parameters.AddWithValue("@model", modelTextBox.Text);
                    command.Parameters.AddWithValue("@seats", seatsNumericUpDown.Value);
                    command.Parameters.AddWithValue("@doors", doorsNumericUpDown.Value);
                    command.Parameters.AddWithValue("@colors", colorsTextBox.Text);
                    command.Parameters.AddWithValue("@heatedSeat", heatedSeatsCheckBox.Checked);
                    command.Parameters.AddWithValue("@age", ageNumericUpDown.Value);
                    command.Parameters.AddWithValue("@condition", conditionTextBox.Text);
                    command.Parameters.AddWithValue("@sun_roof", sunRoofCheckBox.Checked);
                    command.Parameters.AddWithValue("@bluetooth", bluetoothCheckBox.Checked);
                    command.Parameters.AddWithValue("@manual", manualCheckBox.Checked);
                    command.Parameters.AddWithValue("@fuelType", fuelTypeCheckBox.Checked);
                    string selectedPricingModel = pricingModelComboBox.SelectedItem.ToString();
                    int pricingID = Int32.Parse(Regex.Match(selectedPricingModel, @"\d+").Value);
                    command.Parameters.AddWithValue("@pricing_id", pricingID);
                    int returned = command.ExecuteNonQuery();
                    if (returned == 1)
                    {
                        MessageBox.Show("Car type has been added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Car type failed to be not added.");
                    }

                    connection.Close();
                }
            }
        }
        private bool CarTypeTextBoxesFilled()
        {
            TextBox[] allTextBoxes = { manufacturerTextBox, modelTextBox, colorsTextBox, conditionTextBox };
            foreach (TextBox textBox in allTextBoxes)
            {
                if (textBox.TextLength <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
