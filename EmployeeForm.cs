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
    public partial class EmployeeForm : Form
    {
        SqlDataAdapter adapter;
        DataTable dataTable;
        BindingSource bindingSource;
        public EmployeeForm()
        {
            InitializeComponent();
            UpdateComboBoxes();
        }

        private void UpdateComboBoxes()
        {
            customerComboBox.Items.Clear();
            rentalComboBox.Items.Clear();
            branchComboBox.Items.Clear();
            customerComboBox.Text = "";
            rentalComboBox.Text = "";
            branchComboBox.Text = "";
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                        "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                        "Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "select * from customer";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string customerInformation = dataReader[0] + ", " + dataReader[1] + ", " + dataReader[2];
                    customerComboBox.Items.Add(Regex.Replace(customerInformation, @"\s\s+", " "));
                }
                dataReader.Close();

                command.CommandText = "select car.rental_id, dropoff_branch_id from car, rental " +
                                      "where car.rental_id is not null and " +
                                            "car.rental_id = rental.rental_id";
                dataReader = command.ExecuteReader();
                string rentalInformation = "";
                while (dataReader.Read())
                {
                    rentalInformation = "Rental ID: " + dataReader[0] + ", Dropoff branch ID: " + dataReader[1];
                    rentalComboBox.Items.Add(Regex.Replace(rentalInformation, @"\s\s+", " "));
                }
                dataReader.Close();

                command.CommandText = "select branch_id from branch";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string customerInformation = dataReader[0].ToString();
                    branchComboBox.Items.Add(Regex.Replace(customerInformation, @"\s\s+", " "));
                }
                dataReader.Close();

                connection.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm nU = new LoginForm();
            nU.ShowDialog();
            this.Close();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedItem == null)
            {
                bookCustomerErrorLabel.Visible = true;
                return;
            }
            else
            {
                bookCustomerErrorLabel.Visible = false;
            }
            string selectedCustomer = customerComboBox.SelectedItem.ToString();
            int customerID = Int32.Parse(Regex.Match(selectedCustomer, @"\d+").Value);

            // Open booking form and pass in customerID
            CustomerForm customerForm = new CustomerForm(customerID);
            customerForm.ShowDialog();
            UpdateComboBoxes();
        }

        private void addCarInformationButton_Click(object sender, EventArgs e)
        {
            AddCarInformation addCarInformationForm = new AddCarInformation();
            addCarInformationForm.ShowDialog();
            UpdateComboBoxes();
        }

        private void dropOffButton_Click(object sender, EventArgs e)
        {
            string errorText = "";
            dropOffErrorLabel.Text = errorText;
            if (rentalComboBox.SelectedIndex <= -1)
            {
                errorText += "A rental must be selected\n";
            }
            if (branchComboBox.SelectedIndex <= -1)
            {
                errorText += "A drop off branch must be selected\n";
            }
            if (errorText != "")
            {
                dropOffErrorLabel.Text = errorText;
                return;
            }
            string selectedRental = rentalComboBox.SelectedItem.ToString();
            int rentalID = Int32.Parse(Regex.Match(selectedRental, @"\d+").Value);
            int branchID = Int32.Parse(Regex.Match(branchComboBox.Text, @"\d+").Value);
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                "Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "select dropoff_branch_id, customer.gold_star from rental, customer " +
                                      "where rental.rental_id = @rentalID and " +
                                            "customer.customer_id = rental.customer_id;";
                command.Parameters.AddWithValue("@rentalID", rentalID);
                command.ExecuteNonQuery();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int promisedDropoffBranchID = (int)dataReader[0];
                    int gold_star = (int)dataReader[0];
                    if (branchID != promisedDropoffBranchID && gold_star == 0)
                    {
                        MessageBox.Show("Drop off branch does not match the planned drop off branch. Customer must pay a $40 fee.");
                    }
                }
                dataReader.Close();


                command.CommandText = "update car " +
                                      "set rental_id = null, branch_id = @branchID " +
                                      "where car.rental_id = @rentalID2;";
                command.Parameters.AddWithValue("@rentalID2", rentalID);
                command.Parameters.AddWithValue("@branchID", branchID);
               int returned = command.ExecuteNonQuery();
                if (returned == 1)
                {
                    MessageBox.Show("Car has been successfully dropped off.");
                    UpdateComboBoxes();
                }
                else
                {
                    MessageBox.Show("Car drop off failed.");
                }

                connection.Close();
            }
        }
    }
}
