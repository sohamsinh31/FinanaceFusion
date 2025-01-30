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
    public partial class ChangePassword : Form
    {
        NpgsqlConnection DBCon = new NpgsqlConnection("Server=cipg01;port=5432;Database=Hirva_CP_TR126;UserId=postgres;Password=123456;");
        public ChangePassword(string emailadd)
        {
            InitializeComponent();
            txtemail.Text = emailadd;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = "";
            if (txtnewpswd.Text == "")
            {
                err = "!..Please enter the password..!\n";
                lblerrnewpswd.Visible = true;
            }
            else
            {
                lblerrnewpswd.Visible = false;
            }
            if (txtnewpswd.Text == "")
            {
                err = err + "!..Please enter the conform password..!\n";
                lblconpswd.Visible = true;
            }
            else
            {
                lblconpswd.Visible = false;
            }
            if (err == "")
            {
                if (txtnewpswd.Text == txtcnfpswd.Text)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE t_userss SET c_password = @c_password WHERE c_email = @c_email", DBCon);
                    cmd.Parameters.AddWithValue("c_password", txtnewpswd.Text);
                    cmd.Parameters.AddWithValue("c_email", txtemail.Text);

                    try
                    {
                        DBCon.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated password successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating record:{ex.Message}");
                    }
                    finally
                    {
                        DBCon.Close();
                    }
                }
                else
                {
                    lblconpswd.Visible = true;
                    lblconpswd.Text = "*!..Please enter the Same password..!";
                    MessageBox.Show("!..Please enter the Same password..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(err, "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnloginpage_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage("");
            loginPage.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage("");
            loginPage.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtnewpswd.PasswordChar = '\0';
                txtcnfpswd.PasswordChar = '\0';
            }
            else
            {
                txtnewpswd.PasswordChar = '*';
                txtcnfpswd.PasswordChar = '*';
            }
        }
    }
}
