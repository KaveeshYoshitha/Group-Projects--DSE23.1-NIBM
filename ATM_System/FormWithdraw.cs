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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM_System
{
    public partial class FormWithdraw : Form
    {
        public FormWithdraw()
        {
            InitializeComponent();
        }

        private void buttonWithdrawAmount_Click(object sender, EventArgs e)
        {
            try
            {

                string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
                SqlConnection conobj = new SqlConnection(conn);
                conobj.Open();

                //Get Input value
                decimal WithdrawAmount = decimal.Parse(textBoxWithdrawAmount.Text);

                //Get Database value
                decimal withdraw_Amount = 0;

                using (SqlCommand command = new SqlCommand("SELECT withdraw_amount FROM withdraw_table WHERE account_number = '"+ AccountAccesForm.acc_No +"'", conobj))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            withdraw_Amount = reader.GetDecimal(0);
                        }
                    }
                }
                //Substraction the (Input value ==  WithdrawAmount ) and (Databasevalue == withdraw_Amount )
                decimal newValue = withdraw_Amount - WithdrawAmount;


                //Update the Table
                using (SqlCommand command = new SqlCommand("UPDATE withdraw_table SET withdraw_amount = @newValue WHERE account_number = '"+ AccountAccesForm.acc_No +"'", conobj))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    {
                        if (rowsAffected >  0)
                        {
                            MessageBox.Show("Withdraw Amount Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Withdraw Amount Updated Failed. Please Check The Account Number ");
                        }
                    }
                }

                //update check balance table
                using (SqlCommand command = new SqlCommand("UPDATE check_balance_table SET account_balance = @newValue WHERE account_number = '"+ AccountAccesForm.acc_No +"'", conobj))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.ExecuteNonQuery();
                }

                //Update Deposit table
                using (SqlCommand command = new SqlCommand("UPDATE deposit_table SET deposit_amount = @newValue WHERE account_number = '"+ AccountAccesForm.acc_No +"'", conobj))
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

        private void buttonWithdrawCancel_Click(object sender, EventArgs e)
        {
            textBoxWithdrawAmount.Text = string.Empty;
        }

        private void buttonWithdrawExit_Click(object sender, EventArgs e)
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