using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
// 
using FinanceFusion.Helpers;

namespace FinanceFusion.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rgpg = new RegistrationForm();
            rgpg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string query = "SELECT c_password FROM t_users WHERE c_email = @c_email AND c_is_active = TRUE";
                DataTable dt = DatabaseHelper.ExecuteQuery(query, new NpgsqlParameter("@c_email", txtEmail.Text));
                string hashedPassword = dt.Rows[0]["c_password"].ToString();
                if(!DatabaseHelper.ValidateUserExists(txtEmail.Text))
                {
                    MessageBox.Show("User does not exist", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword))
                {
                    // Store credentials in app settings
                    // Properties.Settings.Default.UserEmail = txtusername.Text;
                    // Properties.Settings.Default.IsRemembered = true;
                    // Properties.Settings.Default.Save();
                    // SessionHelper.userId = userId;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new DashboardForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            string errorMessage = "";

            if (!ValidationHelper.IsValidEmail(txtEmail.Text))
            {
                errorMessage += "Please enter a valid email address.\n";
                lblerremail.Visible = true;
            }
            else
            {
                lblerremail.Visible = false;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorMessage += "Please enter a valid password.\n";
                lblerrpasword.Visible = true;
            }
            else
            {
                lblerrpasword.Visible = false;
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {

                txtPassword.PasswordChar = '*';
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}
