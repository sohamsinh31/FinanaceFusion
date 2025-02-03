using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using FinanceFusion.Forms;
using FinanceFusion.Helpers;
using Npgsql;
using System.Net.Mail;
using System.Net;


namespace FinanceFusion.Controllers
{
    public class LoginController
    {
        public static int Login(string email, string pass)
        {
            try
            {
                string query = @"
                SELECT 
                    c_user_id, c_password, c_first_name 
                FROM 
                    t_users 
                WHERE 
                    c_email = @c_email AND c_is_active = TRUE";
                DataTable dt = DatabaseHelper.ExecuteQuery(query, new NpgsqlParameter("@c_email", email));
                string hashedPassword = dt.Rows[0]["c_password"].ToString();
                string userId = dt.Rows[0]["c_user_id"].ToString();
                string username = dt.Rows[0]["c_first_name"].ToString();

                if (!DatabaseHelper.ValidateUserExists(email))
                {
                    MessageBox.Show("User does not exist", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                if (BCrypt.Net.BCrypt.Verify(pass, hashedPassword))
                {
                    // Store credentials in app settings
                    // Properties.Settings.Default.UserEmail = txtusername.Text;
                    // Properties.Settings.Default.IsRemembered = true;
                    // Properties.Settings.Default.Save();
                    SessionHelper.user = new Models.UserModel();
                    SessionHelper.user.UserId = userId;
                    SessionHelper.user.FirstName = username;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new DashboardFormLeft().Show();
                    return 1;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static int SendLink(
            ref string randomcode,
            ref Label lblerremailadd,
            ref Button btnVeryfy,
            ref TextBox txtcode,
            string email)
        {
            try
            {
                string query = @"
                SELECT c_email FROM t_users WHERE c_email = @c_email
                ";
                DataTable dt = DatabaseHelper.ExecuteQuery(query, new NpgsqlParameter("@c_email", email));

                if (dt.Rows.Count > 0)
                {
                    lblerremailadd.Visible = false;
                    string from, pass, messegebody;
                    Random rand = new Random();
                    randomcode = (rand.Next(999999).ToString());
                    MailMessage mailMessage = new MailMessage();
                    string to = (email).ToString();
                    from = "yashpatel12092001@gmail.com";
                    pass = "bzxl ecxn tfiv rnbe ";
                    messegebody = $"Your reset code is {randomcode}";
                    mailMessage.To.Add(to);
                    mailMessage.From = new MailAddress(from);
                    mailMessage.Body = messegebody;
                    mailMessage.Subject = "Password Resetcode";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Code Successsfully send");
                        txtcode.Enabled = true;
                        btnVeryfy.Enabled = true;
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return 0;
                    }
                }
                else
                {
                    MessageBox.Show("Email Not found..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}