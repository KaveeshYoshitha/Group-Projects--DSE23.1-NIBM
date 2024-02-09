using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ATM_System
{
    public partial class AccountAccesForm : Form
    {
        public AccountAccesForm()
        {
            InitializeComponent();
        }

        private void textBoxAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAccountNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPinNum_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckCredentials(int account_number, int pin_Number)


        {
            string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATML01; Integrated Security=true";
            //string connString = "Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATML01; Integrated Security=true";
            //using (SqlConnection connection = new SqlConnection(connString))
            //{
            //  connection.Open();
            //}

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                // Construct the SQL query to check the credentials
                string query = "SELECT COUNT(*) FROM login_table WHERE account_number = @AccountNumber AND pin_number = @PIN";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", account_number);
                    command.Parameters.AddWithValue("@PIN", pin_Number);

                   // command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    //command.Parameters.AddWithValue("@PIN", pinNumber);

                    // Execute the query
                    int count = (int)command.ExecuteScalar();

                    // Return true if a matching record is found, otherwise false
                    return count > 0;
                }
            }
        }

        private void buttonFirstEnter_Click(object sender, EventArgs e)

        {
         

            int enteredAccountNumber;
            int enteredPIN;

            // Check if the entered values are valid integers
            if (!int.TryParse(textBoxAccountNum.Text, out enteredAccountNumber) ||
                !int.TryParse(textBoxPinNum.Text, out enteredPIN))
            {
                MessageBox.Show("Please enter valid numeric values for Account Number and PIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the entered credentials against the database
            if (CheckCredentials(enteredAccountNumber, enteredPIN))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Perform actions for successful login (e.g., open another form, etc.)
                FormAccountManager formAccountManager = new FormAccountManager();
                formAccountManager.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Account Number or PIN. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

