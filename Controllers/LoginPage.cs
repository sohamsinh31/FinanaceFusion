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

namespace FundTransfer
{
    public partial class LoginPage : Form
    {
        NpgsqlConnection DBCon = new NpgsqlConnection("Server=cipg01;port=5432;Database=intern_026;UserId=postgres;Password=123456;");
        public LoginPage(string emailadd)
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
            RegistrationPage rgpg = new RegistrationPage();
            rgpg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                try
                {
                    DBCon.Open();
                    NpgsqlCommand cmdu = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email", DBCon);
                    cmdu.Parameters.AddWithValue("@c_email", txtusername.Text);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdu);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        NpgsqlCommand cmdp = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email AND c_password = @c_password", DBCon);
                        cmdp.Parameters.AddWithValue("@c_email", txtusername.Text);
                        cmdp.Parameters.AddWithValue("@c_password", txtpswd.Text);

                        NpgsqlDataAdapter dap = new NpgsqlDataAdapter(cmdp);
                        DataTable dtp = new DataTable();
                        dap.Fill(dtp);

                        if (dtp.Rows.Count > 0)
                        {
                            MessageBox.Show("user is found .... ");
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Not found..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    DBCon.Close();
                }
                //MessageBox.Show("Login sucessesfully");
            }
        }
        private bool validation()
        {
            string err = "";
            if (txtusername.Text == "")
            {
                err = err + "!..Please enter the Username..! \n";
                lblerrusername.Visible = true;
            }
            else
            {
                lblerrusername.Visible = false;
            }
            if (txtpswd.Text == "")
            {
                err = err + "!..Please enter the Password..! \n";
                lblerrpasword.Visible = true;
            }
            else
            {
                lblerrpasword.Visible = false;
            }

            if (err == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(err, "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
            ForgotePasswordPage forgotePasswordPage = new ForgotePasswordPage();
            forgotePasswordPage.Show();
            this.Hide();
        }
    }
}
