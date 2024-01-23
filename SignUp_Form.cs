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
    public partial class SignUp_Form : Form
    {
        databaseConnector db;
        public SignUp_Form()
        {
            InitializeComponent();
            lblWelcome.Select();
            db = new databaseConnector();
        }
        //
        //placeholder event for Firstname
        private void txtboxFirstName_Enter(object sender, EventArgs e)
        {
            if (txtboxFirstName.Text == "First Name")
            {
                txtboxFirstName.Text = "";
                txtboxFirstName.ForeColor = Color.Black;
            }
        }
        private void txtboxFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxFirstName.Text))
            {
                txtboxFirstName.Text = "First Name";
                txtboxFirstName.ForeColor = Color.DimGray;
            }
        }
        //
        //placeholder event for Lastname
        private void txtboxLastName_Enter(object sender, EventArgs e)
        {
            if (txtboxLastName.Text == "Last Name")
            {
                txtboxLastName.Text = "";
                txtboxLastName.ForeColor = Color.Black;
            }
        }

        private void txtboxLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxLastName.Text))
            {
                txtboxLastName.Text = "Last Name";
                txtboxLastName.ForeColor = Color.DimGray;
            }
        }
        //
        //placeholder event for Username
        private void txtboxUsername_Enter(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "Username")
            {
                txtboxUsername.Text = "";
                txtboxUsername.ForeColor = Color.Black;
            }
        }
        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxUsername.Text))
            {
                txtboxUsername.Text = "Username";
                txtboxUsername.ForeColor = Color.DimGray;
            }
        }
        //
        //placeholder event for Email
        private void txtboxEmail_Enter(object sender, EventArgs e)
        {
            if (txtboxEmail.Text == "Email Address")
            {
                txtboxEmail.Text = "";
                txtboxEmail.ForeColor = Color.Black;
            }
        }
        private void txtboxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxEmail.Text))
            {
                txtboxEmail.Text = "Email Address";
                txtboxEmail.ForeColor = Color.DimGray;
            }
        }
        //
        //placeholder event for password
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
        //placeholder event for retype password
        private void txtboxPasswordRe_Enter(object sender, EventArgs e)
        {
            if (txtboxPasswordRe.Text == "Re-type Password")
            {
                txtboxPasswordRe.Text = "";
                txtboxPasswordRe.ForeColor = Color.Black;
            }
        }
        private void txtboxPasswordRe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPasswordRe.Text))
            {
                txtboxPasswordRe.Text = "Re-type Password";
                txtboxPasswordRe.ForeColor = Color.DimGray;
            }
        }
        //
    }
}
