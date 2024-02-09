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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            {
                string id = textBox_TeacherId.Text;
                string name = textBox_TeacherName.Text;
                string address = textBox_Address.Text;
                string emil = textBox_Email.Text;
                string telephone = textBox_Telephone.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
                SqlCommand cmb = new SqlCommand();
                cmb.Connection = con;


                cmb.CommandText = "insert into Teacher( TeacherId,TeacherName,Address,Email,Telephone) values('" + textBox_TeacherId + "','" + textBox_TeacherName + "','" + textBox_Address + "','" + textBox_Email + "','" + textBox_Telephone + "')";
                SqlDataAdapter Da = new SqlDataAdapter();
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                con.Close();
                MessageBox.Show("Data saved Remeber the Ragistraion ID", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            cmb.CommandText = "update Teacher set TeacherId='" + this.textBox_TeacherId + "',TeacherName='" + this.textBox_TeacherName + "',,Address='" + this.textBox_Email + "',Email='" + this.textBox_Email + "',Telephone='" + this.textBox_Telephone + "'where TeacherId= '" + this.textBox_TeacherId + "' ; ";
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


            SqlCommand vi = new SqlCommand("Select * from Teacher", con);
            SqlDataAdapter sh = new SqlDataAdapter(vi);

            DataTable dt = new DataTable();
            sh.Fill(dt);
            con.Close();
            dataGridView_Teacher.DataSource = dt;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            string sql = "Delete form Teacher where  TeacherId='" +textBox_TeacherId + "'";
            SqlCommand DL = new SqlCommand(sql, con);
            DL.ExecuteNonQuery();
            MessageBox.Show("successfully Delete");
            con.Close();
        }
    }
}
