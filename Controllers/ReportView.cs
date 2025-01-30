using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using OfficeOpenXml; // Requires EPPlus NuGet package

namespace FundTransfer
{
    public partial class ReportView : Form
    {
        private string connectionString = "Server=cipg01;Port=5432;Database=intern088;User Id=postgres;Password=123456;";
        private DataTable incomeData = new DataTable();
        private DataTable expenseData = new DataTable();
        private DataTable allTransactionData = new DataTable();

        public ReportView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        t.c_transaction_id AS TransactionId,
                        t.c_amount AS Amount,
                        c.c_category_name AS Category,
                        ty.c_type_name AS Type,
                        t.c_date_created AS DateCreated
                    FROM t_transactions t
                    INNER JOIN t_categories c ON t.c_category_id = c.c_category_id
                    INNER JOIN t_types ty ON c.c_type_id = ty.c_type_id
                    ORDER BY t.c_date_created DESC";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    allTransactionData.Clear();
                    adapter.Fill(allTransactionData);

                    if (allTransactionData.Rows.Count > 0)
                    {
                        // Filter Income Data
                        var incomeRows = allTransactionData.AsEnumerable().Where(row => row.Field<string>("Type") == "Income");
                        incomeData = incomeRows.Any() ? incomeRows.CopyToDataTable() : allTransactionData.Clone();

                        // Filter Expense Data
                        var expenseRows = allTransactionData.AsEnumerable().Where(row => row.Field<string>("Type") == "Expense");
                        expenseData = expenseRows.Any() ? expenseRows.CopyToDataTable() : allTransactionData.Clone();

                        dataGridView1.DataSource = incomeData;
                        dataGridView2.DataSource = expenseData;

                        UpdateCharts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void UpdateCharts()
        {
            BarChart.Series.Clear();
            IncomeChart.Series.Clear();

            // Calculate total income and expenses
            var totalIncome = incomeData.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));
            var totalExpenses = expenseData.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));

            // Bar Chart: Income vs Expenses (Vertical)
            var seriesBar = new Series("Income vs Expenses")
            {
                ChartType = SeriesChartType.Bar // Bar chart is vertical by default
            };
            seriesBar.Points.AddXY("Income", totalIncome);
            seriesBar.Points.AddXY("Expenses", totalExpenses);
            BarChart.Series.Add(seriesBar);

            // Pie Chart: All Transactions by Category (Combined)
            var categoryGroups = allTransactionData.AsEnumerable()
                .GroupBy(row => row.Field<string>("Category"))
                .Select(g => new { Category = g.Key, Total = g.Sum(row => row.Field<decimal>("Amount")) });

            var seriesPie = new Series("Transactions by Category")
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var category in categoryGroups)
            {
                seriesPie.Points.AddXY(category.Category, category.Total);
            }

            IncomeChart.Series.Add(seriesPie);
        }

        private void ExportToCsv(DataTable table, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write headers
                var columnNames = table.Columns.Cast<DataColumn>().Select(col => col.ColumnName);
                writer.WriteLine(string.Join(",", columnNames));

                // Write rows
                foreach (DataRow row in table.Rows)
                {
                    var fields = row.ItemArray.Select(field => field.ToString());
                    writer.WriteLine(string.Join(",", fields));
                }
            }
        }

        private void ExportToExcel(DataTable table, string fileName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");

                // Write headers
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = table.Columns[col].ColumnName;
                }

                // Write rows
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = table.Rows[row][col];
                    }
                }

                package.SaveAs(new FileInfo(fileName));
            }
        }

        private void btnIncomeCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv", FileName = "IncomeData.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(incomeData, sfd.FileName);
                }
            }
        }

        private void btnIncomeExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx", FileName = "IncomeData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(incomeData, sfd.FileName);
                }
            }
        }

        private void btnExpenseCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv", FileName = "ExpenseData.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(expenseData, sfd.FileName);
                }
            }
        }

        private void btnExpenseExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx", FileName = "ExpenseData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(expenseData, sfd.FileName);
                }
            }
        }

        private void btnExportCharts_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PNG Files (*.png)|*.png", FileName = "Charts.png" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var bitmap = new Bitmap(BarChart.Width + IncomeChart.Width, Math.Max(BarChart.Height, IncomeChart.Height)))
                    {
                        using (var g = Graphics.FromImage(bitmap))
                        {
                            BarChart.DrawToBitmap(bitmap, new Rectangle(0, 0, BarChart.Width, BarChart.Height));
                            IncomeChart.DrawToBitmap(bitmap, new Rectangle(BarChart.Width, 0, IncomeChart.Width, IncomeChart.Height));
                        }
                        bitmap.Save(sfd.FileName);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate Month Dropdown
            cmbMonth.Items.Add("Yearly"); // Option to show data for the full year
            cmbMonth.Items.Add("All Months"); // Option to show all available data

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }

            cmbMonth.SelectedIndex = 1; // Default to "All Months"
        }


        private void UpdateCharts(DataTable filteredData)
        {
            BarChart.Series.Clear();
            IncomeChart.Series.Clear();

            // Calculate total income and expenses
            var totalIncome = incomeData.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));
            var totalExpenses = expenseData.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));

            // Bar Chart: Income vs Expenses
            var seriesBar = new Series("Income vs Expenses")
            {
                ChartType = SeriesChartType.Bar
            };
            seriesBar.Points.AddXY("Income", totalIncome);
            seriesBar.Points.AddXY("Expenses", totalExpenses);
            BarChart.Series.Add(seriesBar);

            // Pie Chart: Transactions by Category for the selected filter
            var categoryGroups = filteredData.AsEnumerable()
                .GroupBy(row => row.Field<string>("Category"))
                .Select(g => new { Category = g.Key, Total = g.Sum(row => row.Field<decimal>("Amount")) });

            var seriesPie = new Series("Transactions by Category")
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var category in categoryGroups)
            {
                seriesPie.Points.AddXY(category.Category, category.Total);
            }

            IncomeChart.Series.Add(seriesPie);
        }



        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1) return; // If no selection, exit

            DataTable filteredData;

            if (cmbMonth.SelectedIndex == 0) // "Yearly" option
            {
                filteredData = allTransactionData; // Use the entire dataset for the current year
            }
            else if (cmbMonth.SelectedIndex == 1) // "All Months" option
            {
                filteredData = allTransactionData; // Show all available data
            }
            else // Specific Month Selection
            {
                int selectedMonth = cmbMonth.SelectedIndex - 1; // Adjust index (Yearly = 0, All Months = 1)
                var filteredRows = allTransactionData.AsEnumerable()
                    .Where(row => row.Field<DateTime>("DateCreated").Month == selectedMonth);

                filteredData = filteredRows.Any() ? filteredRows.CopyToDataTable() : allTransactionData.Clone();
            }

            // Separate Income and Expense data
            var incomeRows = filteredData.AsEnumerable().Where(row => row.Field<string>("Type") == "Income");
            incomeData = incomeRows.Any() ? incomeRows.CopyToDataTable() : filteredData.Clone();

            var expenseRows = filteredData.AsEnumerable().Where(row => row.Field<string>("Type") == "Expense");
            expenseData = expenseRows.Any() ? expenseRows.CopyToDataTable() : filteredData.Clone();

            // Update DataGrids
            dataGridView1.DataSource = incomeData;
            dataGridView2.DataSource = expenseData;

            // Update Charts with the filtered data
            UpdateCharts(filteredData);
        }





    }


}
