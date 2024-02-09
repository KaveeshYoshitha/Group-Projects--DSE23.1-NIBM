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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;

namespace ATM_System
{
    public partial class AccountAccesForm : Form
    {
        public AccountAccesForm()
        {
            InitializeComponent();
        }

       

       

        

        private void buttonFirstEnter_Click(object sender, EventArgs e)
        {
            try
            {

                string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";

                string accountNumber = textBoxAccountNum.Text;
                string pinNumber = textBoxPinNum.Text;
                

                // Check if the account number and pin number are correct
                bool isCorrect = false;

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "SELECT * FROM login_table WHERE account_number = @accountNumber AND pin_number = @pinNumber";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@accountNumber", accountNumber);
                    command.Parameters.AddWithValue("@pinNumber", pinNumber);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isCorrect = true;
                    }
                    reader.Close();
                }

                // If the account number and pin number are correct, open the next form
                if (isCorrect)
                {
                    FormAccountManager formAccountManager = new FormAccountManager();
                    formAccountManager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid account number or pin number");
                }
            }
            catch (Exception ex) 
            {
                throw ex;
                MessageBox.Show("Connection is failed" + ex.Message);
            }



        }

        private void buttonFirstCancel_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
            textBoxAccountNum.Text= string.Empty;
            textBoxPinNum.Text= string.Empty;
        }

        private void buttonFirstExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

