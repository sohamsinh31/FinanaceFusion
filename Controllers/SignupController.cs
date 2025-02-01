using FinanceFusion.Forms;
using FinanceFusion.Helpers;
using Npgsql;

namespace FinanceFusion.Controllers
{
    public class SignupController
    {
        public static void Signup(
            ref Label lblerremailadd,
             ref TextBox txtPassword,
             ref TextBox txtEmail,
             ref TextBox txtLastName,
             ref TextBox txtFirstName)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
            try
            {
                if (DatabaseHelper.ValidateUserExists(txtEmail.Text))
                {
                    lblerremailadd.Visible = true;
                    lblerremailadd.Text = "*Email already exists!";
                    MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = @"
                    INSERT INTO 
                    t_users
                        (c_first_name, c_last_name, c_email, c_password)
                    VALUES 
                        (@c_first_name, @c_last_name, @c_email, @c_password)";

                NpgsqlParameter[] parameters = {
                        new NpgsqlParameter("@c_first_name", txtFirstName.Text),
                        new NpgsqlParameter("@c_last_name", txtLastName.Text),
                        new NpgsqlParameter("@c_email", txtEmail.Text),
                        new NpgsqlParameter("@c_password", hashedPassword),
                    };

                int affectedRows = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (affectedRows == 0)
                {
                    MessageBox.Show("Failed to Register", "Error");
                    return;
                }
                MessageBox.Show("Registered successfully.");

                LoginForm loginform = new LoginForm(txtEmail.Text);
                loginform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}