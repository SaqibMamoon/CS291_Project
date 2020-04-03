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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Employee");
            comboBox1.Items.Add("Administrator");

            createUserButton.Text = "Create User"; cancelButton.Text = "Cancel";

            comboBox1.TabIndex = 0; 
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            textBox4.TabIndex = 4;
            textBox5.TabIndex = 5;
            createUserButton.TabIndex = 6;
            cancelButton.TabIndex = 7;

            usernameLabel.Hide();
            passwordLabel.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            
            createUserButton.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            usernameLabel.Show();
            passwordLabel.Show();
            label3.Show();
            label4.Show();
            
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();

            createUserButton.Show();

            if (index != 0)
            {
                label5.Show();
                textBox5.Show();
            }
            else
            {
                label5.Hide();
                textBox5.Hide();
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm nU = new LoginForm();
            nU.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!TextBoxesFilled())
            {
                errorLabel.Text = "Fill in every form!";
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

                    command.CommandText = "select count(*) from user_info " +
                                          "where (user_info.user_id = @user_id1)";
                    command.Parameters.AddWithValue("@user_id1", textBox1.Text);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // If < 0 then user_id does not exist
                    if (userCount != 0)
                    {
                        errorLabel.Text = "Username already exists.";
                    }
                    else
                    {
                        errorLabel.Text = "";
                        if (comboBox1.SelectedIndex == 0)
                        {
                            // Insert customer information
                            command.CommandText = "insert into customer (first_name, last_name, gold_star) " +
                                                  "values (@first_name, @last_name, @gold_star); " +
                                                  "select SCOPE_IDENTITY()";
                            command.Parameters.AddWithValue("@first_name", textBox3.Text);
                            command.Parameters.AddWithValue("@last_name", textBox4.Text);
                            command.Parameters.AddWithValue("@gold_star", 0);
                            // Save the newly created ID to store in the user_info table
                            int customer_id = Convert.ToInt32(command.ExecuteScalar());

                            // Insert user information
                            command.CommandText = "insert into user_info (user_id, password, customer_id) " +
                                                  "values (@user_id2, @password, @customer_id);";
                            command.Parameters.AddWithValue("@user_id2", textBox1.Text);
                            command.Parameters.AddWithValue("@password", textBox2.Text);
                            command.Parameters.AddWithValue("@customer_id", customer_id);
                            command.ExecuteNonQuery();
                        }

                        else if (comboBox1.SelectedIndex == 1)
                        {
                            try
                            {
                                // Insert employee information
                                command.CommandText = "insert into employee (employee_FName, employee_LName, branch_id) " +
                                                      "values (@first_name, @last_name, @branch_id); " +
                                                      "select SCOPE_IDENTITY()";
                                command.Parameters.AddWithValue("@first_name", textBox3.Text);
                                command.Parameters.AddWithValue("@last_name", textBox4.Text);
                                command.Parameters.AddWithValue("@branch_id", textBox5.Text);
                                // Save the newly created ID to store in the user_info table
                                int employee_id = Convert.ToInt32(command.ExecuteScalar());

                                // Insert user information
                                command.CommandText = "insert into user_info (user_id, password, employee_id) " +
                                                      "values (@user_id2, @password, @employee_id);";
                                command.Parameters.AddWithValue("@user_id2", textBox1.Text);
                                command.Parameters.AddWithValue("@password", textBox2.Text);
                                command.Parameters.AddWithValue("@employee_id", employee_id);
                                command.ExecuteNonQuery();
                            }


                            catch
                            {
                                MessageBox.Show("Branch doesn't exist.");
                            }
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            command.CommandText = "insert into user_info (user_id, password, admin_id) values (@user_id2, @password, 1)";
                            command.Parameters.AddWithValue("@user_id2", textBox1.Text);
                            command.Parameters.AddWithValue("@password", textBox2.Text);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();

                        this.Hide();
                        LoginForm nU = new LoginForm();
                        nU.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private bool TextBoxesFilled()
        {
            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            foreach (TextBox textBox in allTextBoxes)
            {
                if (textBox.Visible == true && textBox.TextLength <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
