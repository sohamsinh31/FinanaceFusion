using FinanceFusion.Helpers;

namespace FinanceFusion.Forms
{
    public partial class DashboardFormLeft : Form
    {
        public DashboardFormLeft()
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
                DashboardForm dashboardRight = new DashboardForm();
                dashboardRight.TopLevel = false;
                dashboardRight.FormBorderStyle = FormBorderStyle.None;
                dashboardRight.Dock = DockStyle.Fill;

                panel2.Controls.Clear();
                panel2.Controls.Add(dashboardRight);
                dashboardRight.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            DashboardForm dashboardRight = new DashboardForm();
            dashboardRight.TopLevel = false;
            dashboardRight.FormBorderStyle = FormBorderStyle.None;
            dashboardRight.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(dashboardRight);
            dashboardRight.Show();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.TopLevel = false;
            addCategoryForm.FormBorderStyle = FormBorderStyle.None;
            addCategoryForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(addCategoryForm);
            addCategoryForm.Show();
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.TopLevel = false;
            incomeForm.FormBorderStyle = FormBorderStyle.None;
            incomeForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(incomeForm);
            incomeForm.Show();
        }

        private void lblExpenses_Click(object sender, EventArgs e)
        {
            ExpenseForm expenseForm = new ExpenseForm();
            expenseForm.TopLevel = false;
            expenseForm.FormBorderStyle = FormBorderStyle.None;
            expenseForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(expenseForm);
            expenseForm.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.TopLevel = false;
            reportForm.FormBorderStyle = FormBorderStyle.None;
            reportForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(reportForm);
            reportForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
