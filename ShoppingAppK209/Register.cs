using ShoppingAppK209.Helpers;
using ShoppingAppK209.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingAppK209
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ShoppingAppContext db = new ShoppingAppContext();
            string fullname = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string rePass = txtRePass.Text;
            string[] myArr = { fullname, email, password, rePass };

            if (Utilities.IsEmpty(myArr))
            {
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please fill all the boxes!";
            }
        }
    }
}
