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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        string Acc = Login.AccNum;
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter and confirm the new pin");
            }
            else if ( Pin1Tb.Text != Pin2Tb.Text)
            {
                MessageBox.Show("Pins do not match");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN='" + Pin1Tb.Text + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN changed successfully");
                    Con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
