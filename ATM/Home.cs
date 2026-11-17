using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin cp = new ChangePin();
            cp.Show();
            this.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        public static String AccNum;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumtbl.Text = "Account Number:"+Login.AccNum;
            AccNum = Login.AccNum;
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.Show();
            this.Hide();
        }

        private void fc_Click(object sender, EventArgs e)
        {
            FastCash fc = new FastCash();
            fc.Show();
            this.Hide();
        }

        private void ms_Click(object sender, EventArgs e)
        {
            MiniStatement ms = new MiniStatement();
            ms.Show();
            this.Hide();
        }
    }
}
