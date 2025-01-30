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

namespace FinanceFusion.Forms
{
    public partial class RegistrationForm
    {
        NpgsqlConnection DBCon = new NpgsqlConnection("Server=cipg01;port=5432;Database=intern_026;UserId=postgres;Password=123456;");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm("");
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(validation())
            {
                //MessageBox.Show("Register suc...!");
                string err = "";
                if (err == "")
                {
                    if (txtpswd.Text == txtconpswd.Text)
                    {

                        lblerremailadd.Visible = false;
                        try
                        {
                            DBCon.Open();
                            NpgsqlCommand cmdu = new NpgsqlCommand("SELECT c_email FROM t_users WHERE c_email = @c_email", DBCon);
                            cmdu.Parameters.AddWithValue("@c_email", txtemailadd.Text);

                            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdu);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                lblerremailadd.Visible = true;
                                lblerremailadd.Text = "*!..Email is already exists..!";
                                MessageBox.Show("!..Email is already exists..!", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO t_users (c_first_name, c_last_name, c_email, c_password) VALUES (@c_first_name, @c_last_name, @c_email, @c_password)", DBCon);

                                cmd.Parameters.AddWithValue("@c_first_name", txtfname.Text);
                                cmd.Parameters.AddWithValue("@c_last_name", txtlname.Text);
                                cmd.Parameters.AddWithValue("@c_email", txtemailadd.Text);
                                cmd.Parameters.AddWithValue("@c_password", txtpswd.Text);

                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Register successfully.");
                                    this.Hide();
                                    LoginForm loginForm = new LoginForm(txtemailadd.Text);
                                    loginForm.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error updating record:{ex.Message}");
                                }
                                finally
                                {
                                    //DBCon.Close();
                                }
                            }

                        }
                        catch (Exception ex)
                        {

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
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            lblerrfnlname.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpswd.PasswordChar = '\0';
                txtconpswd.PasswordChar = '\0';
            }
            else
            {
                txtpswd.PasswordChar = '*';
                txtconpswd.PasswordChar = '*';
            }
        }
        private bool validation()
        {
            string err = "";
            if (txtfname.Text == "")
            {
                err = err + "!..Please enter the First name..! \n";
                lblerrfnlname.Visible = true;
            }
            else
            {
                lblerrfnlname.Visible = false;
            }

            if (txtlname.Text == "")
            {
                err = err + "!..Please enter the Last name..! \n";
                lblerrfnlname.Visible = true;
            }
            else
            {
                lblerrfnlname.Visible = false;
            }

            if (txtemailadd.Text == "")
            {
                err = err + "!..Please enter the Email..! \n";
                lblerremailadd.Visible = true;
            }
            else
            {
                lblerremailadd.Visible = false;
            }

            if (txtpswd.Text == "")
            {
                err = err + "!..Please enter the Password..! \n";
                lblerrpasword.Visible = true;
            }
            else
            {
                if (txtpswd.Text.Length < 6)
                {
                    err = err + "!..Invalid Password, at least 6 character are needed..! \n";
                    lblerrpasword.Text = "*!..Invalid Password, at least 6 character are needed..!";
                    lblerrpasword.Visible = true;
                    //MessageBox.Show("Invalid Password, at least 6 character are needed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblerrpasword.Visible = false;
                }
            }


            if (txtconpswd.Text == "")
            {
                err = err + "!..Please enter the conform password..!\n";
                lblerrconpswd.Visible = true;
            }
            else
            {
                lblerrconpswd.Visible = false;
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
        }
    }
