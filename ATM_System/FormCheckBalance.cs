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

namespace ATM_System
{
    public partial class FormCheckBalance : Form
    {
        public FormCheckBalance()
        {
            InitializeComponent();
        }

        private void buttonCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
                SqlConnection conobj = new SqlConnection(conn);
                conobj.Open();
                

                string sql = "SELECT account_balance FROM check_balance_table WHERE account_number = '"+ AccountAccesForm.acc_No +"'";
                using (SqlCommand command = new SqlCommand(sql, conobj))
                {
                    // Add parameter and assign value to it
                    command.Parameters.AddWithValue("@accountNumber", 1001); // Replace 1001 with the actual account number

                    // Execute the command
                    decimal balance = (decimal)command.ExecuteScalar();
                    textCheckBalanceAmount.Text = balance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is Failed" + ex.Message);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormExit formExit = new FormExit();
            formExit.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAccountManager formAccountManager = new FormAccountManager();
            formAccountManager.Show();
            this.Hide();
        }
    }
}
