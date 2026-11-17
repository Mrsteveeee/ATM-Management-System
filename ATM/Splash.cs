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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            myProgress.Value = starting;
            label2.Text = "" + starting;
            if(myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();    

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
