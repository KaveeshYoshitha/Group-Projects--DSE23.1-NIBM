namespace CollegeManagementSystem
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ViewAll = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.textBox_CourseId = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label_CourseCode = new System.Windows.Forms.Label();
            this.label_CourseId = new System.Windows.Forms.Label();
            this.label_CourseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.AllowUserToOrderColumns = true;
            this.dataGridView_Course.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.GridColor = System.Drawing.Color.White;
            this.dataGridView_Course.Location = new System.Drawing.Point(0, 387);
            this.dataGridView_Course.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.RowHeadersWidth = 51;
            this.dataGridView_Course.RowTemplate.Height = 24;
            this.dataGridView_Course.Size = new System.Drawing.Size(892, 162);
            this.dataGridView_Course.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_ViewAll);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_CourseCode);
            this.panel1.Controls.Add(this.textBox_CourseId);
            this.panel1.Controls.Add(this.textBoxCourseName);
            this.panel1.Controls.Add(this.label_CourseCode);
            this.panel1.Controls.Add(this.label_CourseId);
            this.panel1.Controls.Add(this.label_CourseName);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 388);
            this.panel1.TabIndex = 1;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Navy;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(717, 310);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(83, 40);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_ViewAll
            // 
            this.button_ViewAll.BackColor = System.Drawing.Color.Navy;
            this.button_ViewAll.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewAll.ForeColor = System.Drawing.Color.White;
            this.button_ViewAll.Location = new System.Drawing.Point(595, 310);
            this.button_ViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_ViewAll.Name = "button_ViewAll";
            this.button_ViewAll.Size = new System.Drawing.Size(83, 40);
            this.button_ViewAll.TabIndex = 15;
            this.button_ViewAll.Text = "View All";
            this.button_ViewAll.UseVisualStyleBackColor = false;
            this.button_ViewAll.Click += new System.EventHandler(this.button_ViewAll_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Navy;
            this.button_Update.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(466, 310);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(83, 40);
            this.button_Update.TabIndex = 16;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Navy;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(340, 310);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 40);
            this.button_Save.TabIndex = 17;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course ";
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_CourseCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CourseCode.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseCode.Location = new System.Drawing.Point(340, 230);
            this.textBox_CourseCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(461, 32);
            this.textBox_CourseCode.TabIndex = 1;
            // 
            // textBox_CourseId
            // 
            this.textBox_CourseId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_CourseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CourseId.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseId.Location = new System.Drawing.Point(340, 151);
            this.textBox_CourseId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CourseId.Name = "textBox_CourseId";
            this.textBox_CourseId.Size = new System.Drawing.Size(461, 32);
            this.textBox_CourseId.TabIndex = 1;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(340, 82);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(461, 32);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // label_CourseCode
            // 
            this.label_CourseCode.AutoSize = true;
            this.label_CourseCode.BackColor = System.Drawing.Color.Transparent;
            this.label_CourseCode.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseCode.ForeColor = System.Drawing.Color.White;
            this.label_CourseCode.Location = new System.Drawing.Point(100, 231);
            this.label_CourseCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CourseCode.Name = "label_CourseCode";
            this.label_CourseCode.Size = new System.Drawing.Size(139, 30);
            this.label_CourseCode.TabIndex = 0;
            this.label_CourseCode.Text = "Course Code";
            // 
            // label_CourseId
            // 
            this.label_CourseId.AutoSize = true;
            this.label_CourseId.BackColor = System.Drawing.Color.Transparent;
            this.label_CourseId.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseId.ForeColor = System.Drawing.Color.White;
            this.label_CourseId.Location = new System.Drawing.Point(100, 152);
            this.label_CourseId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CourseId.Name = "label_CourseId";
            this.label_CourseId.Size = new System.Drawing.Size(106, 30);
            this.label_CourseId.TabIndex = 0;
            this.label_CourseId.Text = "Course Id";
            // 
            // label_CourseName
            // 
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.BackColor = System.Drawing.Color.Transparent;
            this.label_CourseName.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseName.ForeColor = System.Drawing.Color.White;
            this.label_CourseName.Location = new System.Drawing.Point(100, 78);
            this.label_CourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(144, 30);
            this.label_CourseName.TabIndex = 0;
            this.label_CourseName.Text = "Course Name";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_CourseName;
        private System.Windows.Forms.Label label_CourseCode;
        private System.Windows.Forms.Label label_CourseId;
        private System.Windows.Forms.TextBox textBox_CourseId;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_ViewAll;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
    }
}