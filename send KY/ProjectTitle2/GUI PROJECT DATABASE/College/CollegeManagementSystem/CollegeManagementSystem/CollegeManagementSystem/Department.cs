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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            {
                string id = textBox_DepartmentId.Text;
                string name = textBox_DepartmentName.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
                SqlCommand cmb = new SqlCommand();
                cmb.Connection = con;


                cmb.CommandText = "insert into Department(DepartmentId ,DepartmentName) values('" + textBox_DepartmentId + "','" + textBox_DepartmentName + "')";
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



            cmb.CommandText = "update  Department set  DepartmentId  ='" + this.textBox_DepartmentId + "',DepartmentName='" + this.textBox_DepartmentName + "'whereDepartmentId = '" + this.textBox_DepartmentId + "' ; ";
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


            SqlCommand vi = new SqlCommand("Select *  from Department ", con);
            SqlDataAdapter sh = new SqlDataAdapter(vi);

            DataTable dt = new DataTable();
            sh.Fill(dt);
            con.Close();
            dataGridView_Department.DataSource = dt;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            string sql = "Delete form Department  where  DepartmentId='" + textBox_DepartmentId + "'";
            SqlCommand DL = new SqlCommand(sql, con);
            DL.ExecuteNonQuery();
            MessageBox.Show("successfully Delete");
            con.Close();
        }
    }
}
