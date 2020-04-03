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
    public partial class CustomerForm : Form
    {
        int customerID;
        int pickupBranchID;
        int dropoffBranchID;
        int car_id;
        string carModelName;
        DateTime endDate;
        Dictionary<string, int> branchLookup = new Dictionary<string, int>();

        private void ResetComboBoxes()
        {
            pickupBranchComboBox.SelectedIndex = -1;
            dropoffBranchComboBox.SelectedIndex = -1;
            selectCarComboBox.SelectedIndex = -1;
            billingCycleComboBox.SelectedIndex = 0;
        }
        public CustomerForm(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
            ResetComboBoxes();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                        "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                        "Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "select * from branch ";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int branchID = (int)dataReader[0];
                    string branchName = (string)dataReader[1];
                    branchLookup[branchName] = branchID;

                    pickupBranchComboBox.Items.Add(branchName);
                    dropoffBranchComboBox.Items.Add(branchName);
                }
                dataReader.Close();

                command.Parameters.AddWithValue("@customerID", customerID);
                command.CommandText = "select first_name, last_name from customer where customer_id = @customerID";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                string firstName = (string)dataReader[0];
                string lastName = (string)dataReader[1];

                customerLabel.Text = $"Booking for customer {firstName.Trim()} {lastName.Trim()}.";

                dataReader.Close();

                connection.Close();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.car_type' table. You can move, or remove it, as needed.
            this.car_typeTableAdapter.Fill(this.database1DataSet1.car_type);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.car_typeTableAdapter.FillBy(this.database1DataSet1.car_type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pickupBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickupBranchComboBox.SelectedIndex == -1)
                return;
            pickupBranchID = branchLookup[pickupBranchComboBox.SelectedItem.ToString()];

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                        "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                        "Integrated Security=True"))
            {
                selectCarComboBox.Items.Clear();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Parameters.AddWithValue("@pickupBranchID", pickupBranchID);

                // Select all cars from branch pickupBranchID that are not booked
                command.CommandText =
                    "select distinct car_type.model from car, car_type " +
                    "where " +
                    "   car.type_id = car_type.type_id and " +
                    "   @pickupBranchID = car.branch_id and " +
                    "   car.rental_id is NULL;";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string carModelName = (string)dataReader[0];
                    selectCarComboBox.Items.Add(carModelName);
                }
                dataReader.Close();

                connection.Close();
            }
            selectCarComboBox.Text = "";
            selectCarComboBox.SelectedIndex = -1;
        }

        private void dropoffBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropoffBranchComboBox.SelectedIndex == -1)
                return;

            dropoffBranchID = branchLookup[dropoffBranchComboBox.SelectedItem.ToString()];
        }

        private void selectCarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCarComboBox.SelectedIndex == -1)
                return;

            carModelName = selectCarComboBox.Text;
            updateCarInfo();
        }

        private void updateCarInfo()
        {
            if (carModelName == null)
                return;

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                            "Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Parameters.AddWithValue("@pickupBranchID", pickupBranchID);
                command.Parameters.AddWithValue("@carModelName", carModelName);

                // Select car
                command.CommandText =
                    "select C.car_id, C.type_id, T.manufacturer, T.model, T.seats, T.doors, T.colors, T.heatedSeat, T.age, T.condition, T.sun_roof, " +
                    "T.bluetooth, T.manual, T.fuelType, P.daily_price, P.weekly_price, P.monthly_price " +
                    "from car as C, car_type as T, pricing_model as P where " +
                    "C.branch_id = @pickupBranchID and " +
                    "C.rental_id is NULL and " +
                    "C.type_id = T.type_id and " +
                    "T.model = @carModelName and " +
                    "P.pricing_id = T.pricing_id";
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                car_id = (int)dataReader[0];
                int type_id = (int)dataReader[1];
                string manufacturer = (string)dataReader[2];
                string model = (string)dataReader[3];
                int seats = (int)dataReader[4];
                int doors = (int)dataReader[5];
                string colors = (string)dataReader[6];
                bool heatedSeat = (bool)dataReader[7];
                int age = (int)dataReader[8];
                string condition = (string)dataReader[9];
                bool sun_roof = (bool)dataReader[10];
                bool bluetooth = (bool)dataReader[11];
                bool manual = (bool)dataReader[12];
                bool fuelType = (bool)dataReader[13];
                Decimal daily_price = (Decimal)dataReader[14];
                Decimal weekly_price = (Decimal)dataReader[15];
                Decimal monthly_price = (Decimal)dataReader[16];

                carTextInfo.Clear();
                carTextInfo.AppendText($"Manufacturer: {manufacturer}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Amount of seats: {seats}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Quantity of doors: {doors}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Colors: {colors}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Sun roof: {sun_roof}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Manual: {manual}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText("Fuel Type: " + (fuelType ? "Regular" : "Premium"));
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Daily rental price: {daily_price}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Weekly rental price: {weekly_price}");
                carTextInfo.AppendText(Environment.NewLine);
                carTextInfo.AppendText($"Monthly rental price: {monthly_price}");

                Decimal price = 0.0M;
                int daysInCycle = 1;
                int numCycles = (int)numCyclesInput.Value;
                if (billingCycleComboBox.SelectedIndex == 0)
                    price = daily_price;
                else if (billingCycleComboBox.SelectedIndex == 1)
                {
                    price = weekly_price;
                    daysInCycle = 7;
                }
                else if (billingCycleComboBox.SelectedIndex == 2)
                {
                    price = monthly_price;
                    daysInCycle = 30;
                }
                Decimal totalPrice = price * numCycles;

                endDate = fromDateTimePicker.Value.AddDays(numCycles * daysInCycle);
                endDateLabel.Text = endDate.ToShortDateString();
                totalCostLabel.Text = totalPrice.ToString();

                dataReader.Close();

                connection.Close();
            }
        }

        private void billingCycleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCarInfo();
        }

        private void numCyclesInput_ValueChanged(object sender, EventArgs e)
        {
            updateCarInfo();
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateCarInfo();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            bool errorOccured = false;
            string errorMessage = "Booking failed.\n";
            if (fromDateTimePicker.Value < DateTime.Now)
            {
                errorMessage += "Booking date must be in the future.\n";
                errorOccured = true;
            }
            if (pickupBranchComboBox.SelectedIndex == -1)
            {
                errorMessage += "Must select a pickup branch.\n";
                errorOccured = true;
            }
            if (dropoffBranchComboBox.SelectedIndex == -1)
            {
                errorMessage += "Must select a dropoff branch.\n";
                errorOccured = true;
            }
            if (selectCarComboBox.SelectedIndex == -1)
            {
                errorMessage += "Must select a car model.\n";
                errorOccured = true;
            }
            if (billingCycleComboBox.SelectedIndex == -1)
            {
                errorMessage += "Must select a billing cycle.\n";
                errorOccured = true;
            }
            if (errorOccured)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            ResetComboBoxes();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                           "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                           "Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Parameters.AddWithValue("@startDate", fromDateTimePicker.Value);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.Parameters.AddWithValue("@customerID", customerID);
                command.Parameters.AddWithValue("@carID", car_id);
                command.Parameters.AddWithValue("@pickupBranchID", pickupBranchID);
                command.Parameters.AddWithValue("@dropoffBranchID", dropoffBranchID);

                command.CommandText =
                    "insert into rental (start_date, end_date, customer_id, car_id, pickup_branch_id, dropoff_branch_id) " +
                    "values (@startDate, @endDate, @customerID, @carID, @pickupBranchID, @dropoffBranchID); " +
                    "select SCOPE_IDENTITY()";
                int rental_id = Convert.ToInt32(command.ExecuteScalar());

                command.Parameters.AddWithValue("@rentalID", rental_id);
                command.CommandText = "update car set rental_id = @rentalID where car_id = @carID";
                command.ExecuteNonQuery();

                // Check gold star
                command.Parameters.AddWithValue("@newYear", new DateTime(DateTime.Now.Year, 1, 1));
                command.CommandText =
                    "select count(*) from rental " +
                    "where customer_id = @customerID and start_date > @newYear";
                int numRentalsThisYear = Convert.ToInt32(command.ExecuteScalar());
                if (numRentalsThisYear == 3)
                {
                    command.CommandText = "update customer set gold_star='true' where customer_id = @customerID";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Recieved gold star!");
                }

                connection.Close();
            }
            MessageBox.Show("Booking created!");
        }
    }
}
