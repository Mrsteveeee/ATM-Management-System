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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        string Acc = Login.AccNum;
        int bal;

        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance PHP: " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        
        private void addTransaction1()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 100);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }
        private void addTransaction2()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 500);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }
        private void addTransaction3()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 1000);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }
        private void addTransaction4()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 2000);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }
        private void addTransaction5()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 5000);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }
        private void addTransaction6()
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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
                    cmd.Parameters.AddWithValue("@Amount", 10000);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message);
            }
        }


        private void hunbtn_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 100;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 100 Withdrawn Successfully");
                    Con.Close();
                    addTransaction1();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 500 Withdrawn Successfully");
                    Con.Close();
                    addTransaction2();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void thoubtn_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 1000 Withdrawn Successfully");
                    Con.Close();
                    addTransaction3();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 2000 Withdrawn Successfully");
                    Con.Close();
                    addTransaction4();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 5000 Withdrawn Successfully");
                    Con.Close();
                    addTransaction5();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void tenthbtn_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHP 10000 Withdrawn Successfully");
                    Con.Close();
                    addTransaction6();
                    getBalance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
 }

