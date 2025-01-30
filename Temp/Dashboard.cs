using FundTransfer;

namespace FundTransfer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
            DashboardRight dashboardRight = new DashboardRight();
            dashboardRight.TopLevel = false;
            dashboardRight.FormBorderStyle = FormBorderStyle.None;
            dashboardRight.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(dashboardRight);
            dashboardRight.Show();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            Add_Category add_Category = new Add_Category();
            add_Category.TopLevel = false;
            add_Category.FormBorderStyle = FormBorderStyle.None;
            add_Category.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(add_Category);
            add_Category.Show();
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            IncomeView incomeView = new IncomeView();
            incomeView.TopLevel = false;
            incomeView.FormBorderStyle = FormBorderStyle.None;
            incomeView.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(incomeView);
            incomeView.Show();
        }

        private void lblExpenses_Click(object sender, EventArgs e)
        {
            ExpanceView expanceView = new ExpanceView();
            expanceView.TopLevel = false;
            expanceView.FormBorderStyle = FormBorderStyle.None;
            expanceView.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(expanceView);
            expanceView.Show();
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
            ReportView reportView = new ReportView();
            reportView.TopLevel = false;
            reportView.FormBorderStyle = FormBorderStyle.None;
            reportView.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(reportView);
            reportView.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
