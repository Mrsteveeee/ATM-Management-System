namespace ATM
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.fc = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Button();
            this.cp = new System.Windows.Forms.Button();
            this.bal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AccNumtbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 94);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(216, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Your Transaction";
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.White;
            this.deposit.Location = new System.Drawing.Point(97, 150);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(186, 46);
            this.deposit.TabIndex = 9;
            this.deposit.Text = "DEPOSIT";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(472, 150);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(186, 46);
            this.withdraw.TabIndex = 10;
            this.withdraw.Text = "WITHDRAW";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // fc
            // 
            this.fc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fc.ForeColor = System.Drawing.Color.White;
            this.fc.Location = new System.Drawing.Point(97, 261);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(186, 46);
            this.fc.TabIndex = 11;
            this.fc.Text = "FAST CASH";
            this.fc.UseVisualStyleBackColor = false;
            this.fc.Click += new System.EventHandler(this.fc_Click);
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ForeColor = System.Drawing.Color.White;
            this.ms.Location = new System.Drawing.Point(472, 265);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(186, 46);
            this.ms.TabIndex = 12;
            this.ms.Text = "MINI STATEMENT";
            this.ms.UseVisualStyleBackColor = false;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // cp
            // 
            this.cp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp.ForeColor = System.Drawing.Color.White;
            this.cp.Location = new System.Drawing.Point(97, 380);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(186, 39);
            this.cp.TabIndex = 13;
            this.cp.Text = "CHANGE PIN";
            this.cp.UseVisualStyleBackColor = false;
            this.cp.Click += new System.EventHandler(this.button5_Click);
            // 
            // bal
            // 
            this.bal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal.ForeColor = System.Drawing.Color.White;
            this.bal.Location = new System.Drawing.Point(472, 378);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(186, 42);
            this.bal.TabIndex = 14;
            this.bal.Text = "BALANCE";
            this.bal.UseVisualStyleBackColor = false;
            this.bal.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 19);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(324, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "LOGOUT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AccNumtbl
            // 
            this.AccNumtbl.AutoSize = true;
            this.AccNumtbl.BackColor = System.Drawing.SystemColors.Control;
            this.AccNumtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AccNumtbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AccNumtbl.Location = new System.Drawing.Point(240, 107);
            this.AccNumtbl.Name = "AccNumtbl";
            this.AccNumtbl.Size = new System.Drawing.Size(216, 31);
            this.AccNumtbl.TabIndex = 4;
            this.AccNumtbl.Text = "Account Number";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 495);
            this.Controls.Add(this.AccNumtbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.fc);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button fc;
        private System.Windows.Forms.Button ms;
        private System.Windows.Forms.Button cp;
        private System.Windows.Forms.Button bal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AccNumtbl;
    }
}