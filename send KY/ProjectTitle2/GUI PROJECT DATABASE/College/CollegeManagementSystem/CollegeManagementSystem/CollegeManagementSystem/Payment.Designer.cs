namespace CollegeManagementSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.dataGridView_Payment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ViewAll = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.textBox_StudentId = new System.Windows.Forms.TextBox();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_StudentName = new System.Windows.Forms.Label();
            this.label_StudentId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Payment
            // 
            this.dataGridView_Payment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payment.Location = new System.Drawing.Point(-1, 385);
            this.dataGridView_Payment.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Payment.Name = "dataGridView_Payment";
            this.dataGridView_Payment.RowHeadersWidth = 51;
            this.dataGridView_Payment.RowTemplate.Height = 24;
            this.dataGridView_Payment.Size = new System.Drawing.Size(892, 162);
            this.dataGridView_Payment.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_ViewAll);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.textBox_Amount);
            this.panel1.Controls.Add(this.textBox_StudentName);
            this.panel1.Controls.Add(this.textBox_StudentId);
            this.panel1.Controls.Add(this.label_Amount);
            this.panel1.Controls.Add(this.label_StudentName);
            this.panel1.Controls.Add(this.label_StudentId);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 387);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Payment";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Navy;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(688, 317);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(83, 40);
            this.button_Delete.TabIndex = 21;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_ViewAll
            // 
            this.button_ViewAll.BackColor = System.Drawing.Color.Navy;
            this.button_ViewAll.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewAll.ForeColor = System.Drawing.Color.White;
            this.button_ViewAll.Location = new System.Drawing.Point(566, 317);
            this.button_ViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_ViewAll.Name = "button_ViewAll";
            this.button_ViewAll.Size = new System.Drawing.Size(83, 40);
            this.button_ViewAll.TabIndex = 22;
            this.button_ViewAll.Text = "View All";
            this.button_ViewAll.UseVisualStyleBackColor = false;
            this.button_ViewAll.Click += new System.EventHandler(this.button_ViewAll_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Navy;
            this.button_Update.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(437, 317);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(83, 40);
            this.button_Update.TabIndex = 23;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Navy;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(310, 317);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 40);
            this.button_Save.TabIndex = 24;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Amount.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Amount.ForeColor = System.Drawing.Color.Black;
            this.textBox_Amount.Location = new System.Drawing.Point(310, 222);
            this.textBox_Amount.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(461, 32);
            this.textBox_Amount.TabIndex = 18;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_StudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StudentName.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentName.ForeColor = System.Drawing.Color.Black;
            this.textBox_StudentName.Location = new System.Drawing.Point(310, 149);
            this.textBox_StudentName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(461, 32);
            this.textBox_StudentName.TabIndex = 19;
            // 
            // textBox_StudentId
            // 
            this.textBox_StudentId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_StudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StudentId.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentId.ForeColor = System.Drawing.Color.Black;
            this.textBox_StudentId.Location = new System.Drawing.Point(310, 87);
            this.textBox_StudentId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StudentId.Name = "textBox_StudentId";
            this.textBox_StudentId.Size = new System.Drawing.Size(461, 32);
            this.textBox_StudentId.TabIndex = 20;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.BackColor = System.Drawing.Color.Transparent;
            this.label_Amount.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.Color.White;
            this.label_Amount.Location = new System.Drawing.Point(120, 220);
            this.label_Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(91, 30);
            this.label_Amount.TabIndex = 15;
            this.label_Amount.Text = "Amount";
            // 
            // label_StudentName
            // 
            this.label_StudentName.AutoSize = true;
            this.label_StudentName.BackColor = System.Drawing.Color.Transparent;
            this.label_StudentName.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentName.ForeColor = System.Drawing.Color.White;
            this.label_StudentName.Location = new System.Drawing.Point(120, 150);
            this.label_StudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(150, 30);
            this.label_StudentName.TabIndex = 16;
            this.label_StudentName.Text = "Student Name";
            // 
            // label_StudentId
            // 
            this.label_StudentId.AutoSize = true;
            this.label_StudentId.BackColor = System.Drawing.Color.Transparent;
            this.label_StudentId.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentId.ForeColor = System.Drawing.Color.White;
            this.label_StudentId.Location = new System.Drawing.Point(120, 88);
            this.label_StudentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentId.Name = "label_StudentId";
            this.label_StudentId.Size = new System.Drawing.Size(112, 30);
            this.label_StudentId.TabIndex = 17;
            this.label_StudentId.Text = "Student Id";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Payment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Payment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_ViewAll;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.TextBox textBox_StudentId;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_StudentName;
        private System.Windows.Forms.Label label_StudentId;
    }
}