namespace ATM_System
{
    partial class FormDeposit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDepositAmount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelWithdrawAmount = new System.Windows.Forms.Panel();
            this.textBoxDepositAmountTitle = new System.Windows.Forms.TextBox();
            this.buttonDepositCancel = new System.Windows.Forms.Button();
            this.buttonDepositExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelWithdrawAmount.SuspendLayout();
            this.SuspendLayout();
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
            this.textBox1.TabIndex = 6;
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
            this.labelLogan.TabIndex = 4;
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
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATM_System.Properties.Resources.Screenshot_2024_01_12_212119;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonDepositExit);
            this.panel1.Controls.Add(this.buttonDepositCancel);
            this.panel1.Controls.Add(this.buttonDepositAmount);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.panelWithdrawAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 681);
            this.panel1.TabIndex = 0;
            // 
            // buttonDepositAmount
            // 
            this.buttonDepositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonDepositAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositAmount.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositAmount.Location = new System.Drawing.Point(92, 403);
            this.buttonDepositAmount.Name = "buttonDepositAmount";
            this.buttonDepositAmount.Size = new System.Drawing.Size(445, 57);
            this.buttonDepositAmount.TabIndex = 9;
            this.buttonDepositAmount.Text = "Deposit";
            this.buttonDepositAmount.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.textBoxDepositAmount);
            this.panel4.Location = new System.Drawing.Point(92, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 57);
            this.panel4.TabIndex = 8;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.textBoxDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepositAmount.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F);
            this.textBoxDepositAmount.ForeColor = System.Drawing.Color.White;
            this.textBoxDepositAmount.Location = new System.Drawing.Point(21, 16);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(377, 26);
            this.textBoxDepositAmount.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 33.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(66, 75);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(312, 60);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Deposit Panel";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelWithdrawAmount
            // 
            this.panelWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panelWithdrawAmount.Controls.Add(this.textBoxDepositAmountTitle);
            this.panelWithdrawAmount.Location = new System.Drawing.Point(92, 263);
            this.panelWithdrawAmount.Name = "panelWithdrawAmount";
            this.panelWithdrawAmount.Size = new System.Drawing.Size(445, 57);
            this.panelWithdrawAmount.TabIndex = 6;
            // 
            // textBoxDepositAmountTitle
            // 
            this.textBoxDepositAmountTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.textBoxDepositAmountTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepositAmountTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F);
            this.textBoxDepositAmountTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxDepositAmountTitle.Location = new System.Drawing.Point(21, 16);
            this.textBoxDepositAmountTitle.Name = "textBoxDepositAmountTitle";
            this.textBoxDepositAmountTitle.Size = new System.Drawing.Size(377, 26);
            this.textBoxDepositAmountTitle.TabIndex = 0;
            this.textBoxDepositAmountTitle.Text = "Enter Deposit Amount";
            this.textBoxDepositAmountTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDepositCancel
            // 
            this.buttonDepositCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonDepositCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositCancel.Location = new System.Drawing.Point(92, 466);
            this.buttonDepositCancel.Name = "buttonDepositCancel";
            this.buttonDepositCancel.Size = new System.Drawing.Size(220, 57);
            this.buttonDepositCancel.TabIndex = 10;
            this.buttonDepositCancel.Text = "Cancel";
            this.buttonDepositCancel.UseVisualStyleBackColor = false;
            // 
            // buttonDepositExit
            // 
            this.buttonDepositExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonDepositExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositExit.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositExit.Location = new System.Drawing.Point(315, 466);
            this.buttonDepositExit.Name = "buttonDepositExit";
            this.buttonDepositExit.Size = new System.Drawing.Size(222, 57);
            this.buttonDepositExit.TabIndex = 11;
            this.buttonDepositExit.Text = "Exit";
            this.buttonDepositExit.UseVisualStyleBackColor = false;
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeposit";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelWithdrawAmount.ResumeLayout(false);
            this.panelWithdrawAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelWithdrawAmount;
        private System.Windows.Forms.TextBox textBoxDepositAmountTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Button buttonDepositAmount;
        private System.Windows.Forms.Button buttonDepositCancel;
        private System.Windows.Forms.Button buttonDepositExit;
    }
}