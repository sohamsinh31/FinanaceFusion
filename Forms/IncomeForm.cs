using FinanceFusion.Controllers;
using FinanceFusion.Models;

namespace FinanceFusion.Forms
{
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
            FundController.LoadTables(ref dataGridView1, 1);
            FundController.LoadCategories(ref InCateBox, 1);
            InCateBox.SelectedIndex = -1;
        }

        private void InCateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InItemBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InIncomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InDescBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InDTBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                TransactionModel newTransaction = new TransactionModel
                {
                    Amount = decimal.Parse(InIncomeBox.Text),
                    Description = InDescBox.Text,
                    CreatedDateTime = InDTBox.Value,
                    CategoryId = Convert.ToInt32(InCateBox.SelectedValue)
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
                int transactionId = Convert.ToInt32(InIdBox.Text.ToString());

                TransactionModel updatedTransaction = new TransactionModel
                {
                    Id = transactionId,
                    Amount = decimal.Parse(InIncomeBox.Text),
                    Description = InDescBox.Text,
                    // UpdatedDateTime = DateTime.Parse(InDTBox.Value),
                    CategoryId = Convert.ToInt32(InCateBox.SelectedValue)
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
            if (InIdBox.Text != "")
            {
                int transactionId = Convert.ToInt32(InIdBox.Text.ToString());

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

        private void button4_Click(object sender, EventArgs e) // Clear Fields
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //InCateBox.SelectedValue = row.Cells["Type"].Value.ToString();
                InIdBox.Text = row.Cells["SRN"].Value.ToString();
                InDescBox.Text = row.Cells["Description"].Value?.ToString();
                InIncomeBox.Text = row.Cells["Amount"].Value?.ToString();

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
                InDTBox.Value = finalDateTime;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(InIncomeBox.Text) || !decimal.TryParse(InIncomeBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid income amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (InCateBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(InDescBox.Text))
            {
                MessageBox.Show("Please enter a description.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            InCateBox.SelectedIndex = -1;
            InDescBox.Text = string.Empty;
            InIncomeBox.Text = string.Empty;
            InDTBox.Value = DateTime.Now;
            InIdBox.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
