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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string id = textBox_StudentId.Text;
            string name = textBox_StudentId.Text;
            string address = textBox_addrss.Text;
            string emil = textBox_Email.Text;
            string telephone = textBox_Telephone.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            cmb.CommandText = "insert into Student( StudentId,StudentName,Address,Email,Telephone) values('" + textBox_StudentId + "','" + textBox_StudentNamw + "','" + textBox_addrss + "','" + textBox_Email + "','" + textBox_Telephone + "')";
            SqlDataAdapter Da = new SqlDataAdapter();
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            con.Close();
            MessageBox.Show("Data saved Remeber the Ragistraion ID", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            cmb.CommandText = "update Student set StudentId='" + this.textBox_StudentId + "',StudentName='" + this.textBox_StudentNamw + "',,Address='" + this.textBox_addrss + "',Email='" + this.textBox_Email + "',Telephone='" + this.textBox_Telephone + "'where StudentId= '" + this.textBox_StudentId + "' ; ";
            SqlDataAdapter su = new SqlDataAdapter();
            DataSet up = new DataSet();
            su.Fill(up);
            MessageBox.Show("successfully update");
            con.Close();

          
            
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            SqlCommand vi = new SqlCommand("Select * from Student ", con);
            SqlDataAdapter sh = new SqlDataAdapter(vi);

            DataTable dt = new DataTable();
            sh.Fill(dt);
            con.Close();
            dataGridView_Student.DataSource = dt;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            string sql = "Delete form Student where StudentId ='" + textBox_StudentId + "'";
            SqlCommand DL = new SqlCommand(sql, con);
            DL.ExecuteNonQuery();
            MessageBox.Show("successfully Delete");
            con.Close();
        }
    }
}
