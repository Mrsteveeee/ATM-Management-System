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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        string Acc = Login.AccNum;
        int bal;
        int newBalance;

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
                    cmd.Parameters.AddWithValue("@Type", "Withdraw");
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

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();   
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login home = new Login();
            home.Show();
            this.Hide();
        }

        private void wdButton_Click(object sender, EventArgs e)
        {
            int amount;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter the amount to withdraw");
            }
            else if (!int.TryParse(textBox1.Text, out amount))
            {
                MessageBox.Show("Please enter a valid number");
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (amount > bal)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                try
                {
                    newBalance = bal - amount;

                    Con.Open();
                    addTransaction(amount);

                    string query = "UPDATE AccountTbl SET Balance = @newBalance WHERE AccNum = @Acc";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@newBalance", newBalance);
                    cmd.Parameters.AddWithValue("@Acc", Acc);

                    cmd.ExecuteNonQuery();

                    Con.Close();


                    MessageBox.Show("Successful Withdrawal!");

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
