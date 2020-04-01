using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class LoginForm : Form
    {
        string username, password;
        public LoginForm()
        {
            /*
            int width = Screen.PrimaryScreen.WorkingArea.Width / 4, 
                height = Screen.PrimaryScreen.WorkingArea.Height / 4;
            this.MaximumSize = new Size(height, width);
            this.MinimumSize = new Size(height, width);
            */
            InitializeComponent();
            
            label1.Text = "Username:";
            label1.AutoSize = false;
            label1.Height = 30;
            label1.Width = 85;
            label1.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label2.Text = "Password:";
            label2.AutoSize = false;
            label2.Height = 30;
            label2.Width = 85;
            label2.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            button1.Text = "Login";
            button2.Text = "New User";

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
                SqlCommand command = new SqlCommand("select customer_id, employee_id from user_info where (user_info.user_id = @user_id1 and user_info.password = @pw)", 
                    connection);
                command.Parameters.AddWithValue("@user_id1", username);
                command.Parameters.AddWithValue("@pw", password);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString().Length > 0)
                        {
                            Customer c = new Customer();
                            changePage(c);
                        }
                        else if (reader[1].ToString().Length > 0)
                        {
                            ChartsForm cF = new ChartsForm();
                            changePage(cF);
                        }
                        else
                        {
                            MessageBox.Show("User does not exist in system.");
                        }
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
