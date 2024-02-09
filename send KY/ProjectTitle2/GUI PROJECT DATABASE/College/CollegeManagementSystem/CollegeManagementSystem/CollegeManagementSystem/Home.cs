using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            menustripl.Visible = false;
        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            Student na = new Student();

            na.Show();
        }

        private void button_Teacher_Click(object sender, EventArgs e)
        {
            Teacher Te = new Teacher();
            Te.Show();
        }

        private void button_Course_Click(object sender, EventArgs e)
        {
            Course co = new Course();

            co.Show();
        }

        private void button_Department_Click(object sender, EventArgs e)
        {
            Department dm = new Department();
            dm.Show();
        }

        private void button_Payment_Click(object sender, EventArgs e)
        {
            Payment pa = new Payment();
            pa.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
