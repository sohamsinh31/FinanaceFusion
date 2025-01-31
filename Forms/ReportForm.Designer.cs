namespace FinanceFusion.Forms
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            btnExpenseCsv = new Button();
            btnExpenseExcel = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnIncomeCsv = new Button();
            btnIncomeExcel = new Button();
            btnExportCharts = new Button();
            toolStrip1 = new ToolStrip();
            lblSelect = new ToolStripLabel();
            cmbMonthSelect = new ToolStripComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BarChart
            // 
            this.BarChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea5.Name = "ChartArea1";
			this.BarChart.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.BarChart.Legends.Add(legend5);
            this.BarChart.Location = new System.Drawing.Point(686, 165);
            this.BarChart.Name = "BarChart";
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Income vs Expenses";
			this.BarChart.Series.Add(series5);
            this.BarChart.Size = new System.Drawing.Size(600, 300);
            this.BarChart.TabIndex = 0;
            // 
            // IncomeChart
            // 
            this.IncomeChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea6.Name = "ChartArea1";
			this.IncomeChart.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.IncomeChart.Legends.Add(legend6);
            this.IncomeChart.Location = new System.Drawing.Point(686, 505);
            this.IncomeChart.Name = "IncomeChart";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series6.Legend = "Legend1";
			series6.Name = "Expenses by Category";
			this.IncomeChart.Series.Add(series6);
            this.IncomeChart.Size = new System.Drawing.Size(600, 300);
            this.IncomeChart.TabIndex = 1;
			// 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(542, 202);
            dataGridView1.TabIndex = 2;
            // 
            // btnExpenseCsv
            // 
            btnExpenseCsv.Anchor = AnchorStyles.None;
            btnExpenseCsv.BackColor = Color.FromArgb(44, 48, 84);
            btnExpenseCsv.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenseCsv.ForeColor = Color.White;
            btnExpenseCsv.Location = new Point(95, 703);
            btnExpenseCsv.Name = "btnExpenseCsv";
            btnExpenseCsv.Size = new Size(193, 42);
            btnExpenseCsv.TabIndex = 3;
            btnExpenseCsv.Text = "Export to CSV";
            btnExpenseCsv.UseVisualStyleBackColor = false;
            btnExpenseCsv.Click += btnExpenseCsv_Click;
            // 
            // btnExpenseExcel
            // 
            btnExpenseExcel.Anchor = AnchorStyles.None;
            btnExpenseExcel.BackColor = Color.FromArgb(44, 48, 84);
            btnExpenseExcel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenseExcel.ForeColor = Color.White;
            btnExpenseExcel.Location = new Point(326, 703);
            btnExpenseExcel.Name = "btnExpenseExcel";
            btnExpenseExcel.Size = new Size(210, 42);
            btnExpenseExcel.TabIndex = 4;
            btnExpenseExcel.Text = "Export to Excel";
            btnExpenseExcel.UseVisualStyleBackColor = false;
            btnExpenseExcel.Click += btnExpenseExcel_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(62, 495);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(542, 202);
            dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 171);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 6;
            label1.Text = "Income";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 467);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 7;
            label2.Text = "Expenses";
            // 
            // btnIncomeCsv
            // 
            btnIncomeCsv.Anchor = AnchorStyles.None;
            btnIncomeCsv.BackColor = Color.FromArgb(44, 48, 84);
            btnIncomeCsv.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncomeCsv.ForeColor = Color.White;
            btnIncomeCsv.Location = new Point(95, 407);
            btnIncomeCsv.Name = "btnIncomeCsv";
            btnIncomeCsv.Size = new Size(193, 40);
            btnIncomeCsv.TabIndex = 8;
            btnIncomeCsv.Text = "Export to CSV";
            btnIncomeCsv.UseVisualStyleBackColor = false;
            btnIncomeCsv.Click += btnIncomeCsv_Click;
            // 
            // btnIncomeExcel
            // 
            btnIncomeExcel.Anchor = AnchorStyles.None;
            btnIncomeExcel.BackColor = Color.FromArgb(44, 48, 84);
            btnIncomeExcel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncomeExcel.ForeColor = Color.White;
            btnIncomeExcel.Location = new Point(326, 407);
            btnIncomeExcel.Name = "btnIncomeExcel";
            btnIncomeExcel.Size = new Size(210, 40);
            btnIncomeExcel.TabIndex = 9;
            btnIncomeExcel.Text = "Export to Excel";
            btnIncomeExcel.UseVisualStyleBackColor = false;
            btnIncomeExcel.Click += btnIncomeExcel_Click;
            // 
            // btnExportCharts
            // 
            btnExportCharts.Anchor = AnchorStyles.None;
            btnExportCharts.BackColor = Color.FromArgb(44, 48, 84);
            btnExportCharts.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportCharts.ForeColor = Color.White;
            btnExportCharts.Location = new Point(207, 751);
            btnExportCharts.Name = "btnExportCharts";
            btnExportCharts.Size = new Size(207, 42);
            btnExportCharts.TabIndex = 10;
            btnExportCharts.Text = "Full Report";
            btnExportCharts.UseVisualStyleBackColor = false;
            btnExportCharts.Click += btnExportCharts_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(44, 48, 84);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblSelect, cmbMonthSelect });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1390, 32);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblSelect
            // 
            lblSelect.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = Color.AliceBlue;
            lblSelect.Name = "lblSelect";
            lblSelect.Overflow = ToolStripItemOverflow.Never;
            lblSelect.Size = new Size(73, 29);
            lblSelect.Text = "Select";
            // 
            // cmbMonthSelect
            // 
            cmbMonthSelect.BackColor = Color.AliceBlue;
            cmbMonthSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonthSelect.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMonthSelect.Name = "cmbMonthSelect";
            cmbMonthSelect.Size = new Size(121, 32);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(686, 493);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 14;
            label3.Text = "PieChart";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(686, 143);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 15;
            label4.Text = "BarChart";
            // 
            // ReportForm
            // 
            ClientSize = new Size(1390, 950);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(btnExportCharts);
            Controls.Add(btnIncomeExcel);
            Controls.Add(btnIncomeCsv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(btnExpenseExcel);
            Controls.Add(btnExpenseCsv);
            Controls.Add(dataGridView1);
            this.Controls.Add(this.IncomeChart);
            this.Controls.Add(this.BarChart);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ReportForm";
            Text = "s";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblSelect;
        private System.Windows.Forms.ToolStripComboBox cmbMonthSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
