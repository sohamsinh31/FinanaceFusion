using FinanceFusion.Controllers;
using FinanceFusion.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceFusion.Forms
{
    public partial class RegistrationForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm("");
            loginForm.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Proceed with registration
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                SignupController.Signup(ref lblerremailadd, ref txtPassword, ref txtEmail, ref txtLastName, ref txtFirstName);
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Please fix the validation errors and try again.",
                    "Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConPassword.PasswordChar = '*';
            }
        }
        private bool ValidateInputs()
        {
            bool error = false;

            // Validate First Name and Last Name
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string pattern = @"^[A-Za-z]+$";

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
            {
                lblerrfnlname.Text = "*Please enter both First and Last Name!";
                lblerrfnlname.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(fname, pattern))
            {
                lblerrfnlname.Text = "*Please enter a valid First Name!";
                lblerrfnlname.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(lname, pattern))
            {
                lblerrfnlname.Text = "*Please enter a valid Last Name!";
                lblerrfnlname.Visible = true;
                error = true;
            }
            else
            {
                lblerrfnlname.Visible = false;
            }

            // Validate Email
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                lblerremailadd.Text = "*Please enter an Email!";
                lblerremailadd.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblerremailadd.Text = "*Please enter a valid Email!";
                lblerremailadd.Visible = true;
                error = true;
            }
            else
            {
                lblerremailadd.Visible = false;
            }

            // Validate Password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblerrpasword.Text = "*Please enter a Password!";
                lblerrpasword.Visible = true;
                error = true;
            }
            else if (txtPassword.Text.Length < 8)
            {
                lblerrpasword.Text = "*Password must be at least 8 characters!";
                lblerrpasword.Visible = true;
                error = true;
            }
            else
            {
                lblerrpasword.Visible = false;
            }

            // Validate Confirm Password
            if (string.IsNullOrEmpty(txtConPassword.Text))
            {
                lblerrconpswd.Text = "*Please confirm your Password!";
                lblerrconpswd.Visible = true;
                error = true;
            }
            else if (txtConPassword.Text != txtPassword.Text)
            {
                lblerrconpswd.Text = "*Passwords do not match!";
                lblerrconpswd.Visible = true;
                error = true;
            }
            else
            {
                lblerrconpswd.Visible = false;
            }

            return !error; // If error is true, return false to indicate validation failed
        }


    }
}
