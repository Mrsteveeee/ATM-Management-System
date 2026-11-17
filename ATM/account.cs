using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e) { }

        private const string ConnStr =
            @"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True";

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || FaNameTb.Text == "" ||
                PhoneTb.Text == "" || AddressTb.Text == "" || OccupationTb.Text == "" ||
                PinTb.Text == "" || EducationTb.SelectedItem == null)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            if (!int.TryParse(AccNumTb.Text, out int accNum) || !int.TryParse(PinTb.Text, out int pin))
            {
                MessageBox.Show("Account number and PIN must be numbers");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    con.Open();
                    string query = @"INSERT INTO AccountTbl
                    (AccNum, Name, FaName, DoB, Phone, Address, Education, Occupation, Pin, Balance)
                    VALUES (@num, @name, @fname, @dob, @phone, @address, @edu, @occ, @pin, @bal)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@num", accNum);
                        cmd.Parameters.AddWithValue("@name", AccNameTb.Text);
                        cmd.Parameters.AddWithValue("@fname", FaNameTb.Text);
                        cmd.Parameters.AddWithValue("@dob", DoBTb.Value.Date);
                        cmd.Parameters.AddWithValue("@phone", PhoneTb.Text);
                        cmd.Parameters.AddWithValue("@address", AddressTb.Text);
                        cmd.Parameters.AddWithValue("@edu", EducationTb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@occ", OccupationTb.Text);
                        cmd.Parameters.AddWithValue("@pin", pin);
                        cmd.Parameters.AddWithValue("@bal", 0);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                MessageBox.Show("Account Created Successfully");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}