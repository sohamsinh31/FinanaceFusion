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
// 
using FinanceFusion.Helpers;

namespace FinanceFusion.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm(string emailadd)
        {
            InitializeComponent();
            txtusername.Text = emailadd;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rgpg = new RegistrationForm();
            rgpg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                if (DatabaseHelper.ValidateLogin(txtusername.Text, txtpswd.Text))
                {
                    // Store credentials in app settings
                    // Properties.Settings.Default.UserEmail = txtusername.Text;
                    // Properties.Settings.Default.IsRemembered = true;
                    // Properties.Settings.Default.Save();

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new DashboardForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!ValidationHelper.IsValidEmail(txtusername.Text))
            {
                errorMessage += "⚠️ Please enter a valid email address.\n";
                lblerrusername.Visible = true;
            }
            else
            {
                lblerrusername.Visible = false;
            }

            if (!ValidationHelper.IsValidPassword(txtpswd.Text))
            {
                errorMessage += "⚠️ Please enter a valid password.\n";
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
            if (checkBox1.Checked)
            {
                txtpswd.PasswordChar = '\0';
            }
            else
            {

                txtpswd.PasswordChar = '*';
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
