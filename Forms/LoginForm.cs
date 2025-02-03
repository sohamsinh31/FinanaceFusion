using FinanceFusion.Helpers;
using FinanceTracker;
using FinanceFusion.Controllers;

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

            if (LoginController.Login(txtEmail.Text, txtPassword.Text) == 1)
            {
                this.Hide();
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
            ForgotePasswordPage forgotPasswordForm = new ForgotePasswordPage();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            ForgotePasswordPage forgotPasswordForm = new ForgotePasswordPage();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}
