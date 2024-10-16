using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierApplication;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashman;
        public frmLoginAccount()
            
        {
            InitializeComponent();
           
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextUser.Text;
            string password = TextPass.Text;

            if (username == "Akhiro" && password == "CASHMAN")
            {
                Cashier cashier = new Cashier(username, password, "Akhiro", "CASHMAN");

                MessageBox.Show("Welcome " + cashier.FullName);

                //close this form the n proceed to form 1
                this.Hide();
                frmPurchaseDiscountedItem form1 = new frmPurchaseDiscountedItem();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
 
}

    

    

