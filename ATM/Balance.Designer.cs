namespace ATM
{
    partial class Balance
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
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BalanceTbl = new System.Windows.Forms.Label();
            this.AccNumberTbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(647, 94);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(609, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(143, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(120, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 25);
            this.label13.TabIndex = 43;
            this.label13.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(120, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Your Balance:";
            // 
            // BalanceTbl
            // 
            this.BalanceTbl.AutoSize = true;
            this.BalanceTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BalanceTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceTbl.Location = new System.Drawing.Point(348, 227);
            this.BalanceTbl.Name = "BalanceTbl";
            this.BalanceTbl.Size = new System.Drawing.Size(83, 25);
            this.BalanceTbl.TabIndex = 46;
            this.BalanceTbl.Text = "Balance";
            // 
            // AccNumberTbl
            // 
            this.AccNumberTbl.AutoSize = true;
            this.AccNumberTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AccNumberTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AccNumberTbl.Location = new System.Drawing.Point(348, 151);
            this.AccNumberTbl.Name = "AccNumberTbl";
            this.AccNumberTbl.Size = new System.Drawing.Size(87, 25);
            this.AccNumberTbl.TabIndex = 45;
            this.AccNumberTbl.Text = "AccNum";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 34);
            this.panel2.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(281, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "BACK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 401);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BalanceTbl);
            this.Controls.Add(this.AccNumberTbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BalanceTbl;
        private System.Windows.Forms.Label AccNumberTbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}