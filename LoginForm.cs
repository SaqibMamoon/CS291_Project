using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class LoginForm : Form
    {
        string username = "";
        string password = "";

        public LoginForm()
        {
            /*
            int width = Screen.PrimaryScreen.WorkingArea.Width / 4, 
                height = Screen.PrimaryScreen.WorkingArea.Height / 4;
            this.MaximumSize = new Size(height, width);
            this.MinimumSize = new Size(height, width);
            */
            InitializeComponent();

            // Define path and DataDirectory to access the database later
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = Path.GetFullPath(Path.Combine((System.IO.Path.GetDirectoryName(executable)), @"..\..\"));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            textBox2.TabIndex = 0;
            textBox1.TabIndex = 1;
            button1.TabIndex = 2;
            button2.TabIndex = 3;
        }

        /*Purpose: To deal with when the log in button is clicked*/
        private void button1_Click(object sender, EventArgs e)
        {
            //Here we will place the check. We can establish multiple different methods for storing users.
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                                                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                                                                    "Integrated Security=True"))
            {
				connection.Open();

				string errorText = "";
                errorLabel.Text = errorText;

				if (username == "")
					errorText += "Please enter a username.\n";
				if (password == "")
					errorText += "Please enter a password.\n";
				if (errorText != "")
                {
                    errorLabel.Text = errorText;
					return;
				}

				SqlCommand command = new SqlCommand();
				command.Connection = connection;
				command.Parameters.AddWithValue("@user_id1", username);
				command.Parameters.AddWithValue("@pw", password);

				command.CommandText = "select count(*) from user_info " +
					  "where (user_info.user_id = @user_id1)";
				bool userExists = Convert.ToInt32(command.ExecuteScalar()) == 1;
                if (!userExists)
				{
                    errorLabel.Text = "Username does not exist.";
					return;
				}

				command.CommandText = "select count(*) from user_info " +
	                "where (user_info.user_id = @user_id1) and (user_info.password = @pw)";
                bool passwordCorrect = Convert.ToInt32(command.ExecuteScalar()) == 1;
                if (!passwordCorrect)
				{
					errorLabel.Text = "Password is incorrect.";
					return;
				}

				command.CommandText = "select customer_id, employee_id, admin_id from user_info where (user_info.user_id = @user_id1 and user_info.password = @pw)";

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() != "")
                            changePage(new CustomerForm((int)reader[0], false));
                        else if (reader[1].ToString() != "")
							changePage(new EmployeeForm());
                        else if (reader[2].ToString() != "")
                            changePage(new ChartsForm());
                        else
                            MessageBox.Show("User does not exist in system.");
                    }
                }
                
                connection.Close();
            }
        }

        private void changePage(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        /*Purpose: To open new window for a new user*/
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            NewUserForm nU = new NewUserForm();
            nU.ShowDialog();
            this.Close();
        }
        /*Purpose: To deal with when the username is changed*/
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            username = textBox2.Text;
        }

        /*Purpose: To deal with when the password is changed*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }
    }
}
