using FinanceFusion.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinanceTracker
{
    public partial class ForgotePasswordPage : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection("Server=cipg01;port=5432;Database=intern_026;UserId=postgres;Password=123456;");

        public string randomcode;
        public static string to;
        bool error = true;
        public ForgotePasswordPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsendcode_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                try
                {
                    cn.Open();
                    NpgsqlCommand cmdu = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email", cn);
                    cmdu.Parameters.AddWithValue("@c_email", txtemail.Text);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdu);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        lblerremailadd.Visible = false;
                        string from, pass, messegebody;
                        Random rand = new Random();
                        randomcode = (rand.Next(999999).ToString());
                        MailMessage mailMessage = new MailMessage();
                        to = (txtemail.Text).ToString();
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Not found..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                lblerremailadd.Visible = true;
                MessageBox.Show("!..Please enter the Email Address..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (error == false)
            {
                lblerrcode.Visible = false;
                if (randomcode == txtcode.Text)
                {
                    // ChangePassword chpswd = new ChangePassword(txtemail.Text);
                    // MessageBox.Show("user is verify");
                    // chpswd.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("user is Not verify...!", "ForgotePasswordPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("!..Error..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm("");
            loginPage.Show();
            this.Hide();
        }

        private void btnloginpage_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm("");
            loginPage.Show();
            this.Hide();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern) == false)
            {
                lblerremailadd.Text = "*!..Please enter the valid Email..!";
                error = true;
                lblerremailadd.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    NpgsqlCommand cmdu = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email", cn);
                    cmdu.Parameters.AddWithValue("@c_email", txtemail.Text);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdu);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        error = false;
                        lblerremailadd.Visible = false;
                    }
                    else
                    {
                        lblerremailadd.Text = "*Email Not found..! \n";
                        error = true;
                        lblerremailadd.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

            string codefmt = txtcode.Text;
            string pattern = @"^[0-9]+$";

            if (txtcode.Text == "")
            {
                error = true;
                lblerrcode.Visible = true;
                lblerrcode.Text = "*plese enter the code..!";
            }
            else if (Regex.IsMatch(codefmt, pattern) == false && txtcode.Text != "")
            {
                lblerrcode.Text = "*Please enter the Number Only..!";
                error = true;
                lblerrcode.Visible = true;
            }
            else
            {
                error = false;
                lblerrcode.Visible = false;
            }
        }
    }
}
