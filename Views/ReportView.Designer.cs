namespace FundTransfer
{
    partial class ReportView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.IncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnExpenseCsv = new System.Windows.Forms.Button();
			this.btnExpenseExcel = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnIncomeCsv = new System.Windows.Forms.Button();
			this.btnIncomeExcel = new System.Windows.Forms.Button();
			this.btnExportCharts = new System.Windows.Forms.Button();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// BarChart
			// 
			chartArea3.Name = "ChartArea1";
			this.BarChart.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.BarChart.Legends.Add(legend3);
			this.BarChart.Location = new System.Drawing.Point(577, 50);
			this.BarChart.Name = "BarChart";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Income vs Expenses";
			this.BarChart.Series.Add(series3);
			this.BarChart.Size = new System.Drawing.Size(400, 300);
			this.BarChart.TabIndex = 0;
			// 
			// IncomeChart
			// 
			chartArea4.Name = "ChartArea1";
			this.IncomeChart.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.IncomeChart.Legends.Add(legend4);
			this.IncomeChart.Location = new System.Drawing.Point(1016, 50);
			this.IncomeChart.Name = "IncomeChart";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series4.Legend = "Legend1";
			series4.Name = "Expenses by Category";
			this.IncomeChart.Series.Add(series4);
			this.IncomeChart.Size = new System.Drawing.Size(400, 300);
			this.IncomeChart.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(50, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(423, 202);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnExpenseCsv
			// 
			this.btnExpenseCsv.Location = new System.Drawing.Point(50, 570);
			this.btnExpenseCsv.Name = "btnExpenseCsv";
			this.btnExpenseCsv.Size = new System.Drawing.Size(150, 30);
			this.btnExpenseCsv.TabIndex = 3;
			this.btnExpenseCsv.Text = "Export to CSV";
			this.btnExpenseCsv.UseVisualStyleBackColor = true;
			this.btnExpenseCsv.Click += new System.EventHandler(this.btnExpenseCsv_Click);
			// 
			// btnExpenseExcel
			// 
			this.btnExpenseExcel.Location = new System.Drawing.Point(220, 570);
			this.btnExpenseExcel.Name = "btnExpenseExcel";
			this.btnExpenseExcel.Size = new System.Drawing.Size(150, 30);
			this.btnExpenseExcel.TabIndex = 4;
			this.btnExpenseExcel.Text = "Export to Excel";
			this.btnExpenseExcel.UseVisualStyleBackColor = true;
			this.btnExpenseExcel.Click += new System.EventHandler(this.btnExpenseExcel_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(50, 351);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(423, 202);
			this.dataGridView2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Income";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Expenses";
			// 
			// btnIncomeCsv
			// 
			this.btnIncomeCsv.Location = new System.Drawing.Point(53, 274);
			this.btnIncomeCsv.Name = "btnIncomeCsv";
			this.btnIncomeCsv.Size = new System.Drawing.Size(150, 30);
			this.btnIncomeCsv.TabIndex = 8;
			this.btnIncomeCsv.Text = "Export to CSV";
			this.btnIncomeCsv.UseVisualStyleBackColor = true;
			this.btnIncomeCsv.Click += new System.EventHandler(this.btnIncomeCsv_Click);
			// 
			// btnIncomeExcel
			// 
			this.btnIncomeExcel.Location = new System.Drawing.Point(220, 274);
			this.btnIncomeExcel.Name = "btnIncomeExcel";
			this.btnIncomeExcel.Size = new System.Drawing.Size(150, 30);
			this.btnIncomeExcel.TabIndex = 9;
			this.btnIncomeExcel.Text = "Export to Excel";
			this.btnIncomeExcel.UseVisualStyleBackColor = true;
			this.btnIncomeExcel.Click += new System.EventHandler(this.btnIncomeExcel_Click);
			// 
			// btnExportCharts
			// 
			this.btnExportCharts.Location = new System.Drawing.Point(577, 383);
			this.btnExportCharts.Name = "btnExportCharts";
			this.btnExportCharts.Size = new System.Drawing.Size(150, 30);
			this.btnExportCharts.TabIndex = 10;
			this.btnExportCharts.Text = "Export Charts";
			this.btnExportCharts.UseVisualStyleBackColor = true;
			this.btnExportCharts.Click += new System.EventHandler(this.btnExportCharts_Click);
			// 
			// cmbMonth
			// 
			this.cmbMonth.FormattingEnabled = true;
			this.cmbMonth.Location = new System.Drawing.Point(388, 278);
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.Size = new System.Drawing.Size(121, 24);
			this.cmbMonth.TabIndex = 11;
			this.Load += new System.EventHandler(this.Form1_Load);
			cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1500, 750);
			this.Controls.Add(this.cmbMonth);
			this.Controls.Add(this.btnExportCharts);
			this.Controls.Add(this.btnIncomeExcel);
			this.Controls.Add(this.btnIncomeCsv);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.btnExpenseExcel);
			this.Controls.Add(this.btnExpenseCsv);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.IncomeChart);
			this.Controls.Add(this.BarChart);
			this.Name = "Form1";
			this.Text = "Financial Dashboard";
			((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExpenseCsv;
        private System.Windows.Forms.Button btnExpenseExcel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIncomeCsv;
        private System.Windows.Forms.Button btnIncomeExcel;
        private System.Windows.Forms.Button btnExportCharts;
		private System.Windows.Forms.ComboBox cmbMonth;
	}
}
