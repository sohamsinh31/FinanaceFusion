namespace FundTransfer
{
    partial class ExpanceView : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        public ExpanceView()
        {
            InitializeComponent();
            FundController.LoadTables(ref dataGridView1, 2);
            FundController.LoadCategories(ref this.ExCateBox, 2);
        }
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            ExIdBox = new TextBox();
            ExDTBox = new DateTimePicker();
            ExDescBox = new TextBox();
            ExIncomeBox = new TextBox();
            ExCateBox = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1073, 258);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 328);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 2;
            label1.Text = "Expance List:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ExIdBox);
            panel3.Controls.Add(ExDTBox);
            panel3.Controls.Add(ExDescBox);
            panel3.Controls.Add(ExIncomeBox);
            panel3.Controls.Add(ExCateBox);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 346);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 355);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 85);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 18;
            label3.Text = "ID:";
            // 
            // ExIdBox
            // 
            ExIdBox.Enabled = false;
            ExIdBox.Location = new Point(249, 82);
            ExIdBox.Name = "ExIdBox";
            ExIdBox.Size = new Size(151, 27);
            ExIdBox.TabIndex = 17;
            // 
            // ExDTBox
            // 
            ExDTBox.Location = new Point(565, 131);
            ExDTBox.Name = "ExDTBox";
            ExDTBox.Size = new Size(250, 27);
            ExDTBox.TabIndex = 14;
            ExDTBox.ValueChanged += ExDTBox_ValueChanged;
            // 
            // ExDescBox
            // 
            ExDescBox.Location = new Point(565, 34);
            ExDescBox.Multiline = true;
            ExDescBox.Name = "ExDescBox";
            ExDescBox.Size = new Size(250, 75);
            ExDescBox.TabIndex = 13;
            ExDescBox.TextChanged += ExDescBox_TextChanged;
            // 
            // ExIncomeBox
            // 
            ExIncomeBox.Location = new Point(249, 124);
            ExIncomeBox.Name = "ExIncomeBox";
            ExIncomeBox.Size = new Size(151, 27);
            ExIncomeBox.TabIndex = 12;
            ExIncomeBox.TextChanged += ExIncomeBox_TextChanged;
            // 
            // ExCateBox
            // 
            ExCateBox.FormattingEnabled = true;
            ExCateBox.Location = new Point(249, 31);
            ExCateBox.Name = "ExCateBox";
            ExCateBox.Size = new Size(151, 28);
            ExCateBox.TabIndex = 10;
            ExCateBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 53, 197);
            button4.ForeColor = Color.FromArgb(255, 255, 255);
            button4.Location = new Point(425, 181);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 53, 197);
            button3.ForeColor = Color.FromArgb(255, 255, 255);
            button3.Location = new Point(306, 181);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 53, 197);
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Location = new Point(181, 181);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 53, 197);
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            button1.Location = new Point(59, 181);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 131);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 34);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 3;
            label7.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 131);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 34);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // ExpanceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 713);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ExpanceView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox ExCateBox;
        private DateTimePicker ExDTBox;
        private TextBox ExDescBox;
        private Label label3;
        private TextBox ExIdBox;
        private TextBox ExIncomeBox;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExItemBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExIncomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExDescBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExDTBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Transaction newTransaction = new Transaction
                {
                    Amount = decimal.Parse(ExIncomeBox.Text),
                    Description = ExDescBox.Text,
                    Date = ExDTBox.Value,
                    CategoryId = Convert.ToInt32(ExCateBox.SelectedValue)
                };

                FundController.InsertTransaction(newTransaction);
                FundController.LoadTables(ref dataGridView1, 1);
                ClearFields();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int transactionId = Convert.ToInt32(ExIdBox.Text.ToString());

                Transaction updatedTransaction = new Transaction
                {
                    TransactionId = transactionId,
                    Amount = decimal.Parse(ExIncomeBox.Text),
                    Description = ExDescBox.Text,
                    Date = ExDTBox.Value,
                    CategoryId = Convert.ToInt32(ExCateBox.SelectedValue)
                };

                FundController.UpdateTransaction(updatedTransaction);
                FundController.LoadTables(ref dataGridView1, 1);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a transaction to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ExIdBox.Text != "")
            {
                int transactionId = Convert.ToInt32(ExIdBox.Text.ToString());

                DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    FundController.DeleteTransaction(transactionId);
                    FundController.LoadTables(ref dataGridView1, 1);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //InCateBox.SelectedValue = row.Cells["Type"].Value.ToString();
                ExIdBox.Text = row.Cells["SRN"].Value.ToString();
                ExDescBox.Text = row.Cells["Description"].Value?.ToString();
                ExIncomeBox.Text = row.Cells["Amount"].Value?.ToString();

                DateTime selectedDate = DateTime.Now;
                if (row.Cells["Date"].Value != null && DateTime.TryParse(row.Cells["Date"].Value.ToString(), out DateTime parsedDate))
                {
                    selectedDate = parsedDate;
                }

                TimeSpan selectedTime = TimeSpan.Zero;
                if (row.Cells["Time"].Value != null && TimeSpan.TryParse(row.Cells["Time"].Value.ToString(), out TimeSpan parsedTime))
                {
                    selectedTime = parsedTime;
                }

                DateTime finalDateTime = selectedDate.Date + selectedTime;
                ExDTBox.Value = finalDateTime;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(ExIncomeBox.Text) || !decimal.TryParse(ExIncomeBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid income amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ExCateBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(ExDescBox.Text))
            {
                MessageBox.Show("Please enter a description.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            ExCateBox.SelectedIndex = -1;
            ExDescBox.Text = string.Empty;
            ExIncomeBox.Text = string.Empty;
            ExDTBox.Value = DateTime.Now;
            ExIdBox.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
