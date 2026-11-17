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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SANTOS\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True;TrustServerCertificate=True");
        string Acc = Home.AccNum;
        private void populate()
        {
            Con.Open();
            string query = "select * from TransactionTbl where AccNum='" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniStatementDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
