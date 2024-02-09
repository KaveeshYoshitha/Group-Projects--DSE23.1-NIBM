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
    public partial class FormDeposit : Form
    {
        public FormDeposit()
        {
            InitializeComponent();
        }

        private void buttonDepositAmount_Click(object sender, EventArgs e)
        {
            try
            {

                string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
                SqlConnection conobj = new SqlConnection(conn);
                conobj.Open();

                //Get Input value
                decimal DepositAmount = decimal.Parse(textBoxDepositAmount.Text);

                //Get Database value
                decimal deposit_amount = 0;

                using (SqlCommand command = new SqlCommand("SELECT deposit_amount FROM deposit_table WHERE account_number = 1001", conobj))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            deposit_amount = reader.GetDecimal(0);
                        }
                    }
                }
                //Substraction the (Input value ==  WithdrawAmount ) and (Databasevalue == withdraw_Amount )
                decimal newValue = deposit_amount + DepositAmount;

                //Update the Table
                using (SqlCommand command = new SqlCommand("UPDATE deposit_table SET deposit_amount = @newValue WHERE account_number = 1001 ", conobj))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    int rowsAffected = command.ExecuteNonQuery();
                    {
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deposit Amount Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Deposit Amount Updated Failed. Please Check The Account Number ");
                        }
                    }
                }

                //update check balance table
                using (SqlCommand command = new SqlCommand("UPDATE check_balance_table SET account_balance = @newValue WHERE account_number = 1001", conobj))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                     command.ExecuteNonQuery();
                    
                    
                }

                //Update Withdraw table
                using (SqlCommand command = new SqlCommand("UPDATE withdraw_table SET withdraw_amount = @newValue WHERE account_number =  1001", conobj))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is Failed" + ex.Message);
            }
        }

        private void buttonDepositCancel_Click(object sender, EventArgs e)
        {
            textBoxDepositAmount.Text = string.Empty;
        }

        private void buttonDepositExit_Click(object sender, EventArgs e)
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
