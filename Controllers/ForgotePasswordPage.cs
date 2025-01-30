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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundTransfer
{
    public partial class ForgotePasswordPage : Form
    {
        NpgsqlConnection DBCon = new NpgsqlConnection("Server=cipg01;port=5432;Database=intern_026;UserId=postgres;Password=123456;");

        public string randomcode;
        public static string to;
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
                    DBCon.Open();
                    NpgsqlCommand cmdu = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email", DBCon);
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
                    DBCon.Close();
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
            if (txtcode.Text != "")
            {
                lblerrcode.Visible = false;
                if (randomcode == txtcode.Text)
                {
                    ChangePassword chpswd = new ChangePassword(txtemail.Text);
                    MessageBox.Show("user is verify");
                    chpswd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("user is Not verify...!", "ForgotePasswordPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblerrcode.Visible = true;
                MessageBox.Show("!..Please enter the code..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage("");
            loginPage.Show();
            this.Hide();
        }

        private void btnloginpage_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage("");
            loginPage.Show();
            this.Hide();
        }
    }
}
