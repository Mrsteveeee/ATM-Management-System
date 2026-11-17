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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();
        }
        public static String AccNum;   
        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNum='" + AccNumTb.Text + "' and Pin='" + PinTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNum = AccNumTb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else 
            { 
                MessageBox.Show("Wrong Account Number or Pin");
            }
            Con.Close();
        }
    }
}
