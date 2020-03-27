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

        public NewUser()
        {
            InitializeComponent();
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Employee");
            comboBox1.Items.Add("Administrator");

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



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
