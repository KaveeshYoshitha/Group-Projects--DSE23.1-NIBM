namespace ATM_System
{
    partial class FormAccountManager
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
            this.buttonCheckBalance = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATM_System.Properties.Resources.Screenshot_2024_01_12_212119;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonCheckBalance);
            this.panel1.Controls.Add(this.buttonDeposit);
            this.panel1.Controls.Add(this.buttonWithdraw);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 681);
            this.panel1.TabIndex = 0;
            // 
            // buttonCheckBalance
            // 
            this.buttonCheckBalance.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckBalance.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckBalance.Location = new System.Drawing.Point(76, 461);
            this.buttonCheckBalance.Name = "buttonCheckBalance";
            this.buttonCheckBalance.Size = new System.Drawing.Size(445, 92);
            this.buttonCheckBalance.TabIndex = 10;
            this.buttonCheckBalance.Text = "Check Balance";
            this.buttonCheckBalance.UseVisualStyleBackColor = false;
            this.buttonCheckBalance.Click += new System.EventHandler(this.buttonCheckBalance_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(76, 345);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(445, 92);
            this.buttonDeposit.TabIndex = 9;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdraw.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWithdraw.Location = new System.Drawing.Point(76, 228);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(445, 92);
            this.buttonWithdraw.TabIndex = 8;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 33.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(66, 75);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(404, 60);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Account Manager";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATM_System.Properties.Resources.Screenshot_2024_01_12_205447;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelLogan);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 681);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 619);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 59);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Headquartes: Colombo, Sri Lanka\r\nFounded: July 2003\r\nFounders: B.H. Dahanayaka, K" +
    "aveesh Yoshitha\r\n";
            // 
            // labelLogan
            // 
            this.labelLogan.AutoSize = true;
            this.labelLogan.BackColor = System.Drawing.Color.Transparent;
            this.labelLogan.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.25F);
            this.labelLogan.Location = new System.Drawing.Point(62, 263);
            this.labelLogan.Name = "labelLogan";
            this.labelLogan.Size = new System.Drawing.Size(304, 24);
            this.labelLogan.TabIndex = 2;
            this.labelLogan.Text = "Bank With Crown, Rule Your Finances.";
            this.labelLogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ATM_System.Properties.Resources.Screenshot_20240112_221740;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(125, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccountManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogan;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonCheckBalance;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBox1;
    }
}