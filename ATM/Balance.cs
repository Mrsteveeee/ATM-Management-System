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

namespace ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + AccNumberTbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceTbl.Text = "PHP: " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberTbl.Text =  Home.AccNum;
            getBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
