namespace ATM
{
    partial class ChangePin
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Pin2Tb = new System.Windows.Forms.TextBox();
            this.Pin1Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 100);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(626, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(151, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(119, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "CONFIRM PIN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(119, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 31);
            this.label13.TabIndex = 45;
            this.label13.Text = "NEW PIN:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(346, 313);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(186, 44);
            this.ConfirmButton.TabIndex = 49;
            this.ConfirmButton.Text = "CONFIRM";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Pin2Tb
            // 
            this.Pin2Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Pin2Tb.Location = new System.Drawing.Point(355, 242);
            this.Pin2Tb.Name = "Pin2Tb";
            this.Pin2Tb.Size = new System.Drawing.Size(186, 30);
            this.Pin2Tb.TabIndex = 48;
            // 
            // Pin1Tb
            // 
            this.Pin1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Pin1Tb.Location = new System.Drawing.Point(355, 165);
            this.Pin1Tb.Name = "Pin1Tb";
            this.Pin1Tb.Size = new System.Drawing.Size(186, 30);
            this.Pin1Tb.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(393, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "LOGOUT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 34);
            this.panel2.TabIndex = 51;
            // 
            // ChangePin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Pin2Tb);
            this.Controls.Add(this.Pin1Tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox Pin2Tb;
        private System.Windows.Forms.TextBox Pin1Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}