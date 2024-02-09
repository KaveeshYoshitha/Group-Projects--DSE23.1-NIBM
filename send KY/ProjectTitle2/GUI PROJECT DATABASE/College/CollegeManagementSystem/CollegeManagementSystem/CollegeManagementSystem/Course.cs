using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        

        private void button_Update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            cmb.CommandText = "update Course set CourseName='" + this. textBoxCourseName+ "',CourseId='" + this.textBox_CourseId + "',CourseCode='" + this.textBox_CourseCode + "'where CourseId= '" + this.textBox_CourseId +"' ";
            SqlDataAdapter su = new SqlDataAdapter();
            DataSet up = new DataSet();
            su.Fill(up);
            MessageBox.Show("successfully update");
            con.Close();
        }

        private void button_ViewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            SqlCommand vi = new SqlCommand("Select Course * from  ", con);
            SqlDataAdapter sh = new SqlDataAdapter(vi);

            DataTable dt = new DataTable();
            sh.Fill(dt);
            con.Close();
            dataGridView_Course.DataSource = dt;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string name = textBoxCourseName.Text;
            string id = textBox_CourseId.Text;
            string CourseCode = textBox_CourseCode.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            cmb.CommandText = "insert into Course (CourseName ,CourseId,CourseCode) values('" + textBoxCourseName + "','" + textBox_CourseId + "','" + textBox_CourseCode + "')";
            SqlDataAdapter Da = new SqlDataAdapter();
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            con.Close();
            MessageBox.Show("Data saved Remeber the Ragistraion ID", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            string sql= "Delete form Course where CourseId='"+ textBox_CourseId+"'";
            SqlCommand DL = new SqlCommand(sql,con);
            DL.ExecuteNonQuery();
            MessageBox.Show("successfully Delete");
            con.Close();
        }
    }
 }

