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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void addTransaction(int amount)
        {
            try
            {
                string query = @"INSERT INTO TransactionTbl
                         (AccNum, Type, Amount, TDate)
                         VALUES
                         (@Acc, @Type, @Amount, @TDate)";

                using (SqlConnection con = new SqlConnection(
                    @"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Acc", Acc);
                    cmd.Parameters.AddWithValue("@Type", "Deposit");
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        string Acc = Login.AccNum;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepoAmtTb.Text) ||
    !int.TryParse(DepoAmtTb.Text, out int depoAmt) ||
    depoAmt <= 0)
            {
                MessageBox.Show("Enter Amount to Deposit");
            }
            else
            {
                

                newBalance = oldBalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=Balance+'" + newBalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Deposited Successfully");
                    Con.Close();
                    addTransaction(depoAmt);
                    Home home = new Home();
                    home.Show();
                    this.Hide();     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        { 
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        int oldBalance, newBalance;

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();

        }
    }
}
