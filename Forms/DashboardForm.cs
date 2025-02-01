using System.Data;
using FinanceFusion.Helpers;
using Npgsql;

namespace FinanceFusion.Forms
{
    public partial class DashboardForm : Form
    {
        string _connectionString;
        private NpgsqlConnection con;

        public DashboardForm()
        {
            InitializeComponent();
            _connectionString = ConfigHelper.GetConnectionString();
            con = new NpgsqlConnection(_connectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //on load Today Income
                decimal totalTodayIncome = GetTodayIncome();
                lblTodayIncome.Text = $"${totalTodayIncome:N2}";

                //on load Month Income
                decimal totalMonthIncome = GetMonthIncome();
                lblMonthIncome.Text = $"${totalMonthIncome:N2}";

                //on load Income Total
                decimal totalIncome = GetTotalIncome();
                lblincm.Text = $"${totalIncome:N2}";

                //on load Today Expense
                decimal totalTodayExpense = GetTodayExpenses();
                lblTodayExpenses.Text = $"${totalTodayExpense:N2}";

                //on load Month Expenses
                decimal totalMonthExpenses = GetMonthExpenses();
                lblMonthExpenses.Text = $"${totalMonthExpenses:N2}";


                //on load Total Expenses 
                decimal totalExpenses = GetTotalExpenses();
                labelExpenses.Text = $"${totalExpenses:N2}";

                //on load Balance Total
                decimal totalBalance = GetTotalBalance();
                labelBalance.Text = $"${totalBalance:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }
        //Today Income
        private decimal GetTodayIncome()
        {
            decimal todayIncome = 0;
            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalIncome" +
                    "FROM t_transactions tINNER JOIN t_categories c " +
                    "ON t.c_category_id = c.c_category_idINNER JOIN t_types ty " +
                    "ON c.c_type_id = ty.c_type_idWHERE ty.c_type_name = 'Income'" +
                    "AND DATE(t.c_date_created) = CURRENT_DATE", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    todayIncome = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return todayIncome;
        }
        // Total Month Income
        private decimal GetMonthIncome()
        {
            decimal monthIncome = 0;
            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalIncome" +
                    "FROM t_transactions t INNER JOIN t_categories c " +
                    "ON t.c_category_id = c.c_category_id" +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id" +
                    "WHERE ty.c_type_name = 'Income'" +
                    "AND DATE_TRUNC('month', t.c_date_created) = DATE_TRUNC('month', CURRENT_DATE)", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    monthIncome = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return monthIncome;
        }
        // Total Income
        private decimal GetTotalIncome()
        {
            decimal totalIncome = 0;

            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalIncome " +
                    "FROM t_transactions t INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id WHERE ty.c_type_name = 'Income'", con);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    totalIncome = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return totalIncome;
        }
        //Today Expenses
        private decimal GetTodayExpenses()
        {
            decimal totalTodayExpenses = 0;

            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalExpenses" +
                    "FROM t_transactions t INNER JOIN t_categories c ON " +
                    "t.c_category_id = c.c_category_id" +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id" +
                    "WHERE ty.c_type_name = 'Expense'AND DATE(t.c_date_created) = CURRENT_DATE;", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    totalTodayExpenses = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return totalTodayExpenses;
        }
        // Month Expenses
        private decimal GetMonthExpenses()
        {
            decimal totalMonthExpense = 0;

            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalExpenses" +
                    "FROM t_transactions tINNER JOIN t_categories c ON " +
                    "t.c_category_id = c.c_category_id " +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id" +
                    "WHERE ty.c_type_name = 'Expense'" +
                    "AND DATE_TRUNC('month', t.c_date_created) = DATE_TRUNC('month', CURRENT_DATE);", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    totalMonthExpense = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return totalMonthExpense;
        }
        //risk to delete
        private void totalExpenses_Click(object sender, PaintEventArgs e)
        {
            //decimal totalExpenses = GetTotalExpenses();
            //lblincm.Text = $"${totalExpenses:N2}";
        }
        //Total Expenses 
        private decimal GetTotalExpenses()
        {
            decimal totalExpenses = 0;

            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalExpenses " +
                           "FROM t_transactions t INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                           "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id WHERE ty.c_type_name = 'Expense'", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    totalExpenses = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return totalExpenses;
        }
        //Total Balance
        private decimal GetTotalBalance()
        {
            decimal totalBalance = 0;

            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(CASE WHEN ty.c_type_name = 'Income' THEN t.c_amount " +
                    "WHEN ty.c_type_name = 'Expense' THEN -t.c_amount ELSE 0 END) AS Balance FROM t_transactions t " +
                    "INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id;", con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    totalBalance = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return totalBalance;
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
