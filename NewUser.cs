using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS291_Project
{
    public partial class NewUser : Form
    {
        string accType;
        public NewUser()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Employee");
            comboBox1.Items.Add("Administrator");

            label1.Text = "Username:";
            label1.AutoSize = false;
            label1.Height = 30;
            label1.Width = 90;
            label1.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label2.Text = "Password:";
            label2.AutoSize = false;
            label2.Height = 30;
            label2.Width = 90;
            label2.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label3.Text = "First Name:";
            label3.AutoSize = false;
            label3.Height = 30;
            label3.Width = 90;
            label3.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label4.Text = "Last Name:";
            label4.AutoSize = false;
            label4.Height = 30;
            label4.Width = 90;
            label4.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label5.Text = "Branch ID:";
            label5.AutoSize = false;
            label5.Height = 30;
            label5.Width = 90;
            label5.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            label6.Text = "Fill in every form!";
            label6.AutoSize = false;
            label6.Height = 60;
            label6.Width = 90;
            label6.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            button1.Text = "Create User"; button2.Text = "Cancel";

            comboBox1.TabIndex = 0; 
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            textBox4.TabIndex = 4;
            button1.TabIndex = 5;
            button2.TabIndex = 6;

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            
            button1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            accType = comboBox1.SelectedItem.ToString();
            int index = comboBox1.SelectedIndex;
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();

            button1.Show();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nU = new Form3();
            nU.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool chec;
            
            if (label5.Visible == true)
            {
                chec = checkInput(true);
                if (!chec)
                {
                    label6.Show();
                }
                else
                {
                    this.Hide();
                    Form3 nU = new Form3();
                    nU.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                chec = checkInput(false);
                if (!chec)
                {
                    label6.Show();
                }
                else
                {
                    this.Hide();
                    Form3 nU = new Form3();
                    nU.ShowDialog();
                    this.Close();
                }

            }
        }

        private bool checkInput(bool l5)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && 
                textBox3.TextLength > 0 && textBox4.TextLength > 0){ }
            else
            {
                return false;
            }
            if (l5)
            {
                if (textBox5.TextLength > 0){ }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
