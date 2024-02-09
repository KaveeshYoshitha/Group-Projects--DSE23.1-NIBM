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
            if(textBoxAccountNum.Text == "AccountNum")
            {
                textBoxAccountNum.Text = "";
            }
        }

        private void textBoxPinNum_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPinNum.Text == null) 
            {
                textBoxPinNum.Text = "0";
            }
        }
    }
}
