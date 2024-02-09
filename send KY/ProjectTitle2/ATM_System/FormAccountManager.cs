using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class FormAccountManager : Form
    {
        public FormAccountManager()
        {
            InitializeComponent();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
            FormWithdraw formWithdraw = new FormWithdraw();
            formWithdraw.Show();
            this.Hide();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
            FormDeposit formDeposit = new FormDeposit();
            formDeposit.Show();
            this.Hide();
        }

        private void buttonCheckBalance_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-KUI5SJ7; Initial Catalog=ATMmyTry; Integrated Security=true";
            FormCheckBalance formCheckBalance = new FormCheckBalance();
            formCheckBalance.Show();
            this.Hide();
        }
    }
}
