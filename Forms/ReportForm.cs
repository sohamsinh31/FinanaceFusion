using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using OfficeOpenXml; // Requires EPPlus NuGet package
//
using FinanceFusion.Helpers;

namespace FinanceFusion.Forms
{
    public partial class ReportForm : Form
    {
        private DataTable incomeData = new DataTable();
        private DataTable expenseData = new DataTable();
        private DataTable allTransactionData = new DataTable();


        public ReportForm()
        {
            if (String.IsNullOrEmpty(SessionHelper.userId))
            {
                MessageBox.Show("User must be logged in to view this form");
                return;
            }
            InitializeComponent();
            ToolStripComboBox cmbMonthSelect = (ToolStripComboBox)toolStrip1.Items["cmbMonthSelect"];
            cmbMonthSelect.SelectedIndexChanged += cmbMonthSelect_SelectedIndexChanged;
        }

        private void LoadData()
        {
            try
            {
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
                WHERE t.c_user_id = @id
                ORDER BY t.c_date_created DESC";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", SessionHelper.userId)
                };
                allTransactionData.Clear();
                allTransactionData = DatabaseHelper.ExecuteQuery(query);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
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
                    MessageBox.Show("Report Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Report Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Report Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Report Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private int AddTableToWorksheet(ExcelWorksheet worksheet, string title, DataTable data, int startRow)
        {
            worksheet.Cells[startRow, 1].Value = title;
            worksheet.Cells[startRow, 1].Style.Font.Bold = true;
            worksheet.Cells[startRow, 1].Style.Font.Size = 12;
            startRow++;

            // Add Headers
            for (int col = 0; col < data.Columns.Count; col++)
            {
                worksheet.Cells[startRow, col + 1].Value = data.Columns[col].ColumnName;
                worksheet.Cells[startRow, col + 1].Style.Font.Bold = true;
            }
            startRow++;

            // Add Data
            for (int row = 0; row < data.Rows.Count; row++)
            {
                for (int col = 0; col < data.Columns.Count; col++)
                {
                    worksheet.Cells[startRow + row, col + 1].Value = data.Rows[row][col].ToString();
                }
            }

            return startRow + data.Rows.Count + 2; // Return new row index after table
        }

        private void SaveChartImage(Chart chart, string filename)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, ChartImageFormat.Png);
                File.WriteAllBytes(filename, ms.ToArray());
            }
        }


        private void btnExportCharts_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Report";
                saveFileDialog.FileName = "Financial_Report.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");

                            int rowIndex = 1;

                            // ✅ Add Title
                            worksheet.Cells[rowIndex, 1].Value = "Financial Report";
                            worksheet.Cells[rowIndex, 1, rowIndex, 4].Merge = true;
                            worksheet.Cells[rowIndex, 1].Style.Font.Bold = true;
                            worksheet.Cells[rowIndex, 1].Style.Font.Size = 14;
                            rowIndex += 2;

                            // ✅ Add Selected Month/Year
                            worksheet.Cells[rowIndex, 1].Value = "Report Period: " + cmbMonthSelect.SelectedItem.ToString();
                            rowIndex += 2;

                            // ✅ Add Income Table
                            rowIndex = AddTableToWorksheet(worksheet, "Income Transactions", incomeData, rowIndex);
                            rowIndex += 2;

                            // ✅ Add Expense Table
                            rowIndex = AddTableToWorksheet(worksheet, "Expense Transactions", expenseData, rowIndex);
                            rowIndex += 2;

                            // ✅ Export Charts
                            SaveChartImage(BarChart, "BarChart.png");
                            SaveChartImage(IncomeChart, "PieChart.png");

                            var barChartImg = worksheet.Drawings.AddPicture("BarChart", new FileInfo("BarChart.png"));
                            barChartImg.SetPosition(rowIndex, 0, 0, 0);
                            rowIndex += 20;

                            var pieChartImg = worksheet.Drawings.AddPicture("PieChart", new FileInfo("PieChart.png"));
                            pieChartImg.SetPosition(rowIndex, 0, 0, 0);
                            rowIndex += 20;

                            // ✅ Save Excel File
                            File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());

                            MessageBox.Show("Report Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                ChartType = SeriesChartType.Column
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
                ChartType = SeriesChartType.Column // Bar chart is vertical by default
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


        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripComboBox cmbMonthSelect1 = (ToolStripComboBox)toolStrip1.Items["cmbMonthSelect"];
            cmbMonthSelect.Items.Add("Yearly");
            cmbMonthSelect.Items.Add("All Months");

            for (int i = 1; i <= 12; i++)
            {
                cmbMonthSelect.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }

            cmbMonthSelect.SelectedIndex = 1;
        }

        private void cmbMonthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cmbMonthSelect = (ToolStripComboBox)toolStrip1.Items["cmbMonthSelect"];
            if (cmbMonthSelect.SelectedIndex == -1) return;

            DataTable filteredData;

            if (cmbMonthSelect.SelectedIndex == 0) // "Yearly"
            {
                filteredData = allTransactionData;
            }
            else if (cmbMonthSelect.SelectedIndex == 1) // "All Months"
            {
                filteredData = allTransactionData;
            }
            else // Specific Month
            {
                int selectedMonth = cmbMonthSelect.SelectedIndex - 1;
                var filteredRows = allTransactionData.AsEnumerable()
                    .Where(row => row.Field<DateTime>("DateCreated").Month == selectedMonth);

                filteredData = filteredRows.Any() ? filteredRows.CopyToDataTable() : allTransactionData.Clone();
            }

            var incomeRows = filteredData.AsEnumerable().Where(row => row.Field<string>("Type") == "Income");
            incomeData = incomeRows.Any() ? incomeRows.CopyToDataTable() : filteredData.Clone();

            var expenseRows = filteredData.AsEnumerable().Where(row => row.Field<string>("Type") == "Expense");
            expenseData = expenseRows.Any() ? expenseRows.CopyToDataTable() : filteredData.Clone();

            dataGridView1.DataSource = incomeData;
            dataGridView2.DataSource = expenseData;

            UpdateCharts(filteredData);
        }
    }
}

