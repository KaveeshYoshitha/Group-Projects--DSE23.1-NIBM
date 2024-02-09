namespace ATM_System
{
    partial class FormWithdraw
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
            this.buttonWithdrawExit = new System.Windows.Forms.Button();
            this.buttonWithdrawCancel = new System.Windows.Forms.Button();
            this.buttonWithdrawAmount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.panelWithdrawAmount = new System.Windows.Forms.Panel();
            this.textBoxWithdrawAmountTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.textBox1.TabIndex = 5;
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
            this.labelLogan.TabIndex = 3;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATM_System.Properties.Resources.Screenshot_2024_01_12_212119;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonWithdrawExit);
            this.panel1.Controls.Add(this.buttonWithdrawCancel);
            this.panel1.Controls.Add(this.buttonWithdrawAmount);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelWithdrawAmount);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 681);
            this.panel1.TabIndex = 0;
            // 
            // buttonWithdrawExit
            // 
            this.buttonWithdrawExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonWithdrawExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawExit.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawExit.Location = new System.Drawing.Point(315, 466);
            this.buttonWithdrawExit.Name = "buttonWithdrawExit";
            this.buttonWithdrawExit.Size = new System.Drawing.Size(222, 57);
            this.buttonWithdrawExit.TabIndex = 10;
            this.buttonWithdrawExit.Text = "Exit";
            this.buttonWithdrawExit.UseVisualStyleBackColor = false;
            this.buttonWithdrawExit.Click += new System.EventHandler(this.buttonWithdrawExit_Click);
            // 
            // buttonWithdrawCancel
            // 
            this.buttonWithdrawCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonWithdrawCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawCancel.Location = new System.Drawing.Point(92, 466);
            this.buttonWithdrawCancel.Name = "buttonWithdrawCancel";
            this.buttonWithdrawCancel.Size = new System.Drawing.Size(220, 57);
            this.buttonWithdrawCancel.TabIndex = 9;
            this.buttonWithdrawCancel.Text = "Cancel";
            this.buttonWithdrawCancel.UseVisualStyleBackColor = false;
            this.buttonWithdrawCancel.Click += new System.EventHandler(this.buttonWithdrawCancel_Click);
            // 
            // buttonWithdrawAmount
            // 
            this.buttonWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonWithdrawAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawAmount.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawAmount.Location = new System.Drawing.Point(92, 403);
            this.buttonWithdrawAmount.Name = "buttonWithdrawAmount";
            this.buttonWithdrawAmount.Size = new System.Drawing.Size(445, 57);
            this.buttonWithdrawAmount.TabIndex = 8;
            this.buttonWithdrawAmount.Text = "Withdraw";
            this.buttonWithdrawAmount.UseVisualStyleBackColor = false;
            this.buttonWithdrawAmount.Click += new System.EventHandler(this.buttonWithdrawAmount_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.textBoxWithdrawAmount);
            this.panel4.Location = new System.Drawing.Point(92, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 57);
            this.panel4.TabIndex = 6;
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.textBoxWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWithdrawAmount.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F);
            this.textBoxWithdrawAmount.ForeColor = System.Drawing.Color.White;
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(21, 16);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(377, 26);
            this.textBoxWithdrawAmount.TabIndex = 0;
            // 
            // panelWithdrawAmount
            // 
            this.panelWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panelWithdrawAmount.Controls.Add(this.textBoxWithdrawAmountTitle);
            this.panelWithdrawAmount.Location = new System.Drawing.Point(92, 263);
            this.panelWithdrawAmount.Name = "panelWithdrawAmount";
            this.panelWithdrawAmount.Size = new System.Drawing.Size(445, 57);
            this.panelWithdrawAmount.TabIndex = 5;
            // 
            // textBoxWithdrawAmountTitle
            // 
            this.textBoxWithdrawAmountTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.textBoxWithdrawAmountTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWithdrawAmountTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F);
            this.textBoxWithdrawAmountTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxWithdrawAmountTitle.Location = new System.Drawing.Point(21, 16);
            this.textBoxWithdrawAmountTitle.Name = "textBoxWithdrawAmountTitle";
            this.textBoxWithdrawAmountTitle.Size = new System.Drawing.Size(377, 26);
            this.textBoxWithdrawAmountTitle.TabIndex = 0;
            this.textBoxWithdrawAmountTitle.Text = "Enter Withdraw Amount";
            this.textBoxWithdrawAmountTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 33.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(66, 75);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 60);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Withdraw Panel";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(15)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(92, 529);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(445, 57);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormWithdraw
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
            this.Name = "FormWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWithdraw";
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelWithdrawAmount;
        private System.Windows.Forms.TextBox textBoxWithdrawAmountTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxWithdrawAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWithdrawAmount;
        private System.Windows.Forms.Button buttonWithdrawCancel;
        private System.Windows.Forms.Button buttonWithdrawExit;
        private System.Windows.Forms.Button buttonBack;
    }
}