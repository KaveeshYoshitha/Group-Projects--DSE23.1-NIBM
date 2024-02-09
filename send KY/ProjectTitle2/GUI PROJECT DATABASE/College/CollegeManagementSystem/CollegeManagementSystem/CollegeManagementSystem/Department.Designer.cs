namespace CollegeManagementSystem
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_DepartmentName = new System.Windows.Forms.TextBox();
            this.textBox_DepartmentId = new System.Windows.Forms.TextBox();
            this.label_DepartmentName = new System.Windows.Forms.Label();
            this.label_stid = new System.Windows.Forms.Label();
            this.dataGridView_Department = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_insert);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.textBox_DepartmentName);
            this.panel1.Controls.Add(this.textBox_DepartmentId);
            this.panel1.Controls.Add(this.label_DepartmentName);
            this.panel1.Controls.Add(this.label_stid);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 384);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Department";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Navy;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(707, 315);
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
            this.button_insert.Location = new System.Drawing.Point(585, 315);
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
            this.button_Update.Location = new System.Drawing.Point(458, 315);
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
            this.button_Save.Location = new System.Drawing.Point(330, 315);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 40);
            this.button_Save.TabIndex = 21;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_DepartmentName
            // 
            this.textBox_DepartmentName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_DepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DepartmentName.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DepartmentName.Location = new System.Drawing.Point(328, 213);
            this.textBox_DepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DepartmentName.Name = "textBox_DepartmentName";
            this.textBox_DepartmentName.Size = new System.Drawing.Size(463, 32);
            this.textBox_DepartmentName.TabIndex = 1;
            // 
            // textBox_DepartmentId
            // 
            this.textBox_DepartmentId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_DepartmentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DepartmentId.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DepartmentId.Location = new System.Drawing.Point(328, 130);
            this.textBox_DepartmentId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DepartmentId.Name = "textBox_DepartmentId";
            this.textBox_DepartmentId.Size = new System.Drawing.Size(463, 32);
            this.textBox_DepartmentId.TabIndex = 1;
            // 
            // label_DepartmentName
            // 
            this.label_DepartmentName.AutoSize = true;
            this.label_DepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.label_DepartmentName.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DepartmentName.ForeColor = System.Drawing.Color.White;
            this.label_DepartmentName.Location = new System.Drawing.Point(91, 211);
            this.label_DepartmentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DepartmentName.Name = "label_DepartmentName";
            this.label_DepartmentName.Size = new System.Drawing.Size(191, 30);
            this.label_DepartmentName.TabIndex = 0;
            this.label_DepartmentName.Text = "Department Name";
            // 
            // label_stid
            // 
            this.label_stid.AutoSize = true;
            this.label_stid.BackColor = System.Drawing.Color.Transparent;
            this.label_stid.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stid.ForeColor = System.Drawing.Color.White;
            this.label_stid.Location = new System.Drawing.Point(91, 128);
            this.label_stid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stid.Name = "label_stid";
            this.label_stid.Size = new System.Drawing.Size(153, 30);
            this.label_stid.TabIndex = 0;
            this.label_stid.Text = "Department Id";
            // 
            // dataGridView_Department
            // 
            this.dataGridView_Department.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Department.GridColor = System.Drawing.Color.White;
            this.dataGridView_Department.Location = new System.Drawing.Point(-1, 383);
            this.dataGridView_Department.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Department.Name = "dataGridView_Department";
            this.dataGridView_Department.RowHeadersWidth = 51;
            this.dataGridView_Department.RowTemplate.Height = 24;
            this.dataGridView_Department.Size = new System.Drawing.Size(892, 165);
            this.dataGridView_Department.TabIndex = 3;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.dataGridView_Department);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Department";
            this.Text = "Department";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_DepartmentName;
        private System.Windows.Forms.TextBox textBox_DepartmentId;
        private System.Windows.Forms.Label label_DepartmentName;
        private System.Windows.Forms.Label label_stid;
        private System.Windows.Forms.DataGridView dataGridView_Department;
    }
}