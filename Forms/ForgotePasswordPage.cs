using FinanceFusion.Controllers;
using FinanceFusion.Feeders;
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
        NpgsqlConnection cn = DBFeeder.DBCon;

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
                LoginController.SendLink(ref randomcode, ref lblerremailadd, ref btnVeryfy, ref txtcode, txtemail.Text);
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
                    DashboardFormLeft dashBoard = new DashboardFormLeft();
                    dashBoard.Show();
                    this.Hide();
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
