namespace CollegeManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menustripl = new System.Windows.Forms.Panel();
            this.button_Department = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Payment = new System.Windows.Forms.Button();
            this.button_Course = new System.Windows.Forms.Button();
            this.button_Teacher = new System.Windows.Forms.Button();
            this.button_Student = new System.Windows.Forms.Button();
            this.menustripl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripl
            // 
            this.menustripl.BackColor = System.Drawing.Color.Navy;
            this.menustripl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menustripl.BackgroundImage")));
            this.menustripl.Controls.Add(this.button_Department);
            this.menustripl.Controls.Add(this.button_Exit);
            this.menustripl.Controls.Add(this.button_Payment);
            this.menustripl.Controls.Add(this.button_Course);
            this.menustripl.Controls.Add(this.button_Teacher);
            this.menustripl.Controls.Add(this.button_Student);
            this.menustripl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menustripl.ForeColor = System.Drawing.Color.White;
            this.menustripl.Location = new System.Drawing.Point(0, 0);
            this.menustripl.Margin = new System.Windows.Forms.Padding(2);
            this.menustripl.Name = "menustripl";
            this.menustripl.Size = new System.Drawing.Size(327, 547);
            this.menustripl.TabIndex = 1;
            // 
            // button_Department
            // 
            this.button_Department.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Department.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Department.Location = new System.Drawing.Point(77, 293);
            this.button_Department.Margin = new System.Windows.Forms.Padding(2);
            this.button_Department.Name = "button_Department";
            this.button_Department.Size = new System.Drawing.Size(109, 45);
            this.button_Department.TabIndex = 1;
            this.button_Department.Text = "Department";
            this.button_Department.UseVisualStyleBackColor = false;
            this.button_Department.Click += new System.EventHandler(this.button_Department_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(77, 446);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(109, 45);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Payment
            // 
            this.button_Payment.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Payment.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Payment.Location = new System.Drawing.Point(77, 369);
            this.button_Payment.Margin = new System.Windows.Forms.Padding(2);
            this.button_Payment.Name = "button_Payment";
            this.button_Payment.Size = new System.Drawing.Size(109, 45);
            this.button_Payment.TabIndex = 0;
            this.button_Payment.Text = "Payment";
            this.button_Payment.UseVisualStyleBackColor = false;
            this.button_Payment.Click += new System.EventHandler(this.button_Payment_Click);
            // 
            // button_Course
            // 
            this.button_Course.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Course.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Course.Location = new System.Drawing.Point(77, 214);
            this.button_Course.Margin = new System.Windows.Forms.Padding(2);
            this.button_Course.Name = "button_Course";
            this.button_Course.Size = new System.Drawing.Size(109, 45);
            this.button_Course.TabIndex = 0;
            this.button_Course.Text = "Course";
            this.button_Course.UseVisualStyleBackColor = false;
            this.button_Course.Click += new System.EventHandler(this.button_Course_Click);
            // 
            // button_Teacher
            // 
            this.button_Teacher.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Teacher.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Teacher.Location = new System.Drawing.Point(77, 136);
            this.button_Teacher.Margin = new System.Windows.Forms.Padding(2);
            this.button_Teacher.Name = "button_Teacher";
            this.button_Teacher.Size = new System.Drawing.Size(109, 45);
            this.button_Teacher.TabIndex = 0;
            this.button_Teacher.Text = "Teacher";
            this.button_Teacher.UseVisualStyleBackColor = false;
            this.button_Teacher.Click += new System.EventHandler(this.button_Teacher_Click);
            // 
            // button_Student
            // 
            this.button_Student.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Student.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Student.Location = new System.Drawing.Point(77, 60);
            this.button_Student.Margin = new System.Windows.Forms.Padding(2);
            this.button_Student.Name = "button_Student";
            this.button_Student.Size = new System.Drawing.Size(109, 45);
            this.button_Student.TabIndex = 0;
            this.button_Student.Text = "Student";
            this.button_Student.UseVisualStyleBackColor = false;
            this.button_Student.Click += new System.EventHandler(this.button_Student_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 547);
            this.Controls.Add(this.menustripl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menustripl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menustripl;
        private System.Windows.Forms.Button button_Student;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Payment;
        private System.Windows.Forms.Button button_Course;
        private System.Windows.Forms.Button button_Teacher;
        private System.Windows.Forms.Button button_Department;
    }
}