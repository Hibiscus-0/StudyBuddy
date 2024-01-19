using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {            
            InitializeComponent();
            lblWelcomeBack.Select();
        }
        //
        //placeholder event for username
        //
        private void txtboxUsername_Enter(object sender, EventArgs e)
        {
            if(txtboxUsername.Text == "Username or Email")
            {
                txtboxUsername.Text = "";
                txtboxUsername.ForeColor = Color.Black;
            }
        }
        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtboxUsername.Text))
            {
                txtboxUsername.Text = "Username or Email";
                txtboxUsername.ForeColor = Color.DimGray;
            }
        }
        //
        //placeholder event for password
        //
        private void txtboxPassword_Enter(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "Password")
            {
                txtboxPassword.Text = "";
                txtboxPassword.ForeColor = Color.Black;
            }
        }
        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPassword.Text))
            {
                txtboxPassword.Text = "Password";
                txtboxPassword.ForeColor = Color.DimGray;
            }
        }
        //
        //
        //
        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked) 
            {
                txtboxPassword.PasswordChar = '\0';
            }
            else
            {
                txtboxPassword.PasswordChar = '•';
            }
        }
    }
}
