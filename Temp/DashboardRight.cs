using System.Data;
using System.Windows.Forms;
using Npgsql;
namespace FundTransfer
{
    public partial class DashboardRight : Form
    {
        NpgsqlConnection cn = DBFeeder.DBCon;

        public DashboardRight()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            decimal totalIncome = GetTotalIncome();
            lblincm.Text = $"${totalIncome:N2}";

            decimal totalExpenses = GetTotalExpenses();
            labelExpenses.Text = $"${totalExpenses:N2}";


            decimal totalBalance = GetTotalBalance();
            labelBalance.Text = $"${totalBalance:N2}";
        }
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblIncome_Click(object sender, EventArgs e)
        {

        }

        private void lblExpenses_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }

        private void lblIncomeDetails_Click(object sender, EventArgs e)
        {

        }

        private void panelExpenses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExpensesDetails_Click(object sender, EventArgs e)
        {

        }

        private void panelTotIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTotExpenses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalExpenses_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }
        private decimal GetTotalIncome()
        {
            decimal totalIncome = 0;

            try
            {
                cn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalIncome " +
                    "FROM t_transactions t INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id WHERE ty.c_type_name = 'Income'", cn);

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
                cn.Close();
            }

            return totalIncome;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void totalExpenses_Click(object sender, PaintEventArgs e)
        {
            //decimal totalExpenses = GetTotalExpenses();
            //lblincm.Text = $"${totalExpenses:N2}";
        }
        private decimal GetTotalExpenses()
        {
            decimal totalExpenses = 0;

            try
            {
                cn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(t.c_amount) AS TotalExpenses " +
                           "FROM t_transactions t INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                           "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id WHERE ty.c_type_name = 'Expense'", cn);
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
                cn.Close();
            }
            return totalExpenses;
        }

        private void labelExpenses_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        private decimal GetTotalBalance()
        {
            decimal totalBalance = 0;

            try
            {
                cn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(CASE WHEN ty.c_type_name = 'Income' THEN t.c_amount " +
                    "WHEN ty.c_type_name = 'Expense' THEN t.c_amount ELSE 0 END) AS Balance FROM t_transactions t " +
                    "INNER JOIN t_categories c ON t.c_category_id = c.c_category_id " +
                    "INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id;", cn);
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
                cn.Close();
            }
            return totalBalance;
        }
    }
}
