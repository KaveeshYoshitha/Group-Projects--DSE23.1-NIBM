namespace CollegeManagementSystem
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Telephone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_addrss = new System.Windows.Forms.TextBox();
            this.textBox_StudentNamw = new System.Windows.Forms.TextBox();
            this.textBox_StudentId = new System.Windows.Forms.TextBox();
            this.label_Telephone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_addrss = new System.Windows.Forms.Label();
            this.label_StudentNamw = new System.Windows.Forms.Label();
            this.label_stid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.AllowUserToOrderColumns = true;
            this.dataGridView_Student.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.GridColor = System.Drawing.Color.White;
            this.dataGridView_Student.Location = new System.Drawing.Point(-2, 385);
            this.dataGridView_Student.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.RowHeadersWidth = 51;
            this.dataGridView_Student.RowTemplate.Height = 24;
            this.dataGridView_Student.Size = new System.Drawing.Size(892, 162);
            this.dataGridView_Student.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_insert);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.textBox_Telephone);
            this.panel1.Controls.Add(this.textBox_Email);
            this.panel1.Controls.Add(this.textBox_addrss);
            this.panel1.Controls.Add(this.textBox_StudentNamw);
            this.panel1.Controls.Add(this.textBox_StudentId);
            this.panel1.Controls.Add(this.label_Telephone);
            this.panel1.Controls.Add(this.label_Email);
            this.panel1.Controls.Add(this.label_addrss);
            this.panel1.Controls.Add(this.label_StudentNamw);
            this.panel1.Controls.Add(this.label_stid);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 384);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(415, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Student ";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Navy;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(708, 330);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(83, 40);
            this.button_Delete.TabIndex = 18;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.Navy;
            this.button_insert.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.Color.White;
            this.button_insert.Location = new System.Drawing.Point(586, 330);
            this.button_insert.Margin = new System.Windows.Forms.Padding(2);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(83, 40);
            this.button_insert.TabIndex = 19;
            this.button_insert.Text = "View All";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Navy;
            this.button_Update.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(458, 330);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(83, 40);
            this.button_Update.TabIndex = 20;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Navy;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(331, 330);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 40);
            this.button_Save.TabIndex = 21;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Telephone.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telephone.Location = new System.Drawing.Point(328, 272);
            this.textBox_Telephone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(463, 32);
            this.textBox_Telephone.TabIndex = 1;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(328, 219);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(463, 32);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_addrss
            // 
            this.textBox_addrss.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_addrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_addrss.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addrss.Location = new System.Drawing.Point(328, 163);
            this.textBox_addrss.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addrss.Name = "textBox_addrss";
            this.textBox_addrss.Size = new System.Drawing.Size(463, 32);
            this.textBox_addrss.TabIndex = 1;
            // 
            // textBox_StudentNamw
            // 
            this.textBox_StudentNamw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_StudentNamw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StudentNamw.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentNamw.Location = new System.Drawing.Point(328, 112);
            this.textBox_StudentNamw.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StudentNamw.Name = "textBox_StudentNamw";
            this.textBox_StudentNamw.Size = new System.Drawing.Size(463, 32);
            this.textBox_StudentNamw.TabIndex = 1;
            // 
            // textBox_StudentId
            // 
            this.textBox_StudentId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_StudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StudentId.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentId.Location = new System.Drawing.Point(328, 62);
            this.textBox_StudentId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StudentId.Name = "textBox_StudentId";
            this.textBox_StudentId.Size = new System.Drawing.Size(463, 32);
            this.textBox_StudentId.TabIndex = 1;
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.label_Telephone.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telephone.ForeColor = System.Drawing.Color.White;
            this.label_Telephone.Location = new System.Drawing.Point(122, 267);
            this.label_Telephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(110, 30);
            this.label_Telephone.TabIndex = 0;
            this.label_Telephone.Text = "Telephone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.Location = new System.Drawing.Point(122, 214);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(64, 30);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "Email";
            // 
            // label_addrss
            // 
            this.label_addrss.AutoSize = true;
            this.label_addrss.BackColor = System.Drawing.Color.Transparent;
            this.label_addrss.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addrss.ForeColor = System.Drawing.Color.White;
            this.label_addrss.Location = new System.Drawing.Point(122, 158);
            this.label_addrss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addrss.Name = "label_addrss";
            this.label_addrss.Size = new System.Drawing.Size(92, 30);
            this.label_addrss.TabIndex = 0;
            this.label_addrss.Text = "Address";
            // 
            // label_StudentNamw
            // 
            this.label_StudentNamw.AutoSize = true;
            this.label_StudentNamw.BackColor = System.Drawing.Color.Transparent;
            this.label_StudentNamw.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentNamw.ForeColor = System.Drawing.Color.White;
            this.label_StudentNamw.Location = new System.Drawing.Point(122, 108);
            this.label_StudentNamw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentNamw.Name = "label_StudentNamw";
            this.label_StudentNamw.Size = new System.Drawing.Size(150, 30);
            this.label_StudentNamw.TabIndex = 0;
            this.label_StudentNamw.Text = "Student Name";
            // 
            // label_stid
            // 
            this.label_stid.AutoSize = true;
            this.label_stid.BackColor = System.Drawing.Color.Transparent;
            this.label_stid.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stid.ForeColor = System.Drawing.Color.White;
            this.label_stid.Location = new System.Drawing.Point(122, 58);
            this.label_stid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stid.Name = "label_stid";
            this.label_stid.Size = new System.Drawing.Size(112, 30);
            this.label_stid.TabIndex = 0;
            this.label_stid.Text = "Student Id";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_stid;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_addrss;
        private System.Windows.Forms.Label label_StudentNamw;
        private System.Windows.Forms.Label label_Telephone;
        private System.Windows.Forms.TextBox textBox_StudentId;
        private System.Windows.Forms.TextBox textBox_Telephone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_addrss;
        private System.Windows.Forms.TextBox textBox_StudentNamw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
    }
}