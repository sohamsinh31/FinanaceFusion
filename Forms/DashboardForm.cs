using System;
using System.Data;
using System.Windows.Forms;
using FinanceFusion.Helpers;
using Npgsql;

namespace FinanceFusion.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly string _connectionString;

        public DashboardForm()
        {
            if (SessionHelper.user == null)
            {
                MessageBox.Show("Login to view page");
                LoginForm lf = new LoginForm("");
                lf.Show();
                return;
            }
            else
            {
                InitializeComponent();
                _connectionString = ConfigHelper.GetConnectionString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Load dashboard values
                lblTodayIncome.Text = $"${GetTodayIncome():N2}";
                lblMonthIncome.Text = $"${GetMonthIncome():N2}";
                lblincm.Text = $"${GetTotalIncome():N2}";
                lblTodayExpenses.Text = $"${GetTodayExpenses():N2}";
                lblMonthExpenses.Text = $"${GetMonthExpenses():N2}";
                labelExpenses.Text = $"${GetTotalExpenses():N2}";
                labelBalance.Text = $"${GetTotalBalance():N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executes a SQL query that returns a single decimal value.
        /// </summary>
        private decimal ExecuteScalarQuery(string query)
        {
            using (var con = new NpgsqlConnection(_connectionString))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        // Today Income
        private decimal GetTodayIncome()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Income' AND DATE(t.c_date_created) = CURRENT_DATE";
            return ExecuteScalarQuery(query);
        }

        // Month Income
        private decimal GetMonthIncome()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Income' 
                AND DATE_TRUNC('month', t.c_date_created) = DATE_TRUNC('month', CURRENT_DATE)";
            return ExecuteScalarQuery(query);
        }

        // Total Income
        private decimal GetTotalIncome()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Income'";
            return ExecuteScalarQuery(query);
        }

        // Today Expenses
        private decimal GetTodayExpenses()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Expense' AND DATE(t.c_date_created) = CURRENT_DATE";
            return ExecuteScalarQuery(query);
        }

        // Month Expenses
        private decimal GetMonthExpenses()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Expense' 
                AND DATE_TRUNC('month', t.c_date_created) = DATE_TRUNC('month', CURRENT_DATE)";
            return ExecuteScalarQuery(query);
        }

        // Total Expenses
        private decimal GetTotalExpenses()
        {
            string query = @"
                SELECT SUM(t.c_amount) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                WHERE ty.c_type_name = 'Expense'";
            return ExecuteScalarQuery(query);
        }

        // Total Balance
        private decimal GetTotalBalance()
        {
            string query = @"
                SELECT SUM(CASE WHEN ty.c_type_name = 'Income' THEN t.c_amount 
                WHEN ty.c_type_name = 'Expense' THEN -t.c_amount ELSE 0 END) 
                FROM t_transactions t
                INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id";
            return ExecuteScalarQuery(query);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm("");
            loginPage.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm signUpPage = new RegistrationForm();
            signUpPage.Show();
        }
    }
}
