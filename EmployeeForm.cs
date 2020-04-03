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
        }

        private void addCarInformationButton_Click(object sender, EventArgs e)
        {
            AddCarInformation addCarInformationForm = new AddCarInformation();
            addCarInformationForm.ShowDialog();
        }
    }
}
