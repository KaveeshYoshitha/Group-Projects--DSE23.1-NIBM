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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string id = textBox_StudentId.Text;
            string name = textBox_StudentName.Text;
            string Amount = textBox_Amount.Text;
           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;


            cmb.CommandText = "insert into Payment( StudentId,StudentName,Amount) values('" + textBox_StudentId + "','" + textBox_StudentName + "','" + textBox_Amount + "')";
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


            
            cmb.CommandText = "update Payment  set   StudentId ='" + this.textBox_StudentId + "',StudentName='" + this.textBox_StudentName + "',Amount='" + this.textBox_Amount + "',where StudentId= '" + this.textBox_StudentId + "' ; ";
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


            SqlCommand vi = new SqlCommand("Select * from Payment ",con);
            SqlDataAdapter sh = new SqlDataAdapter(vi);

            DataTable dt = new DataTable();
            sh.Fill(dt);
            con.Close();
            dataGridView_Payment.DataSource = dt;

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP-0KF3IBB;database=CollegeManagment; integrated security=True";
            SqlCommand cmb = new SqlCommand();
            cmb.Connection = con;



            string sql = "Delete form Payment where StudentId ='" + textBox_StudentId + "'";
            SqlCommand DL = new SqlCommand(sql, con);
            DL.ExecuteNonQuery();
            MessageBox.Show("successfully Delete");
            con.Close();
        }
    }
}
