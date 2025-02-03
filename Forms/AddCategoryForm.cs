// using System.Windows.Media;
using System.Data;
//
using FinanceFusion.Helpers;

using Npgsql;
using FinanceFusion.Models;
using FinanceFusion.Controllers;

namespace FinanceFusion.Forms
{
    public partial class AddCategoryForm : Form
    {
        private string _connectionString;
        private NpgsqlConnection con;

        public AddCategoryForm()
        {
            InitializeComponent();
            _connectionString = ConfigHelper.GetConnectionString();
            con = new NpgsqlConnection(_connectionString);
            CategoryController.LoadData(ref CategoryData);
            CategoryController.LoadType(ref cmb_type);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CategoryData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = CategoryData.SelectedRows[0];
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.Id = Convert.ToInt32(row.Cells["c_category_id"].Value);
            categoryModel.CategoryName = txtBox_Name.Text;
            string typeName = cmb_type.Text;
            categoryModel.TypeId = GetTypeId(typeName);

            if (categoryModel.TypeId == -1)
            {
                MessageBox.Show("Invalid category type. Please select a valid type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoryController.UpdateData(categoryModel);
            CategoryController.LoadData(ref CategoryData);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CategoryData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = CategoryData.SelectedRows[0];
            int categoryId = Convert.ToInt32(row.Cells["c_category_id"].Value);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                CategoryController.DeleteData(categoryId);
                CategoryController.LoadData(ref CategoryData);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox_Name.Clear();
            cmb_type.Text = "Select Type";
            dateTimePicker1.Value = DateTime.Now;
        }





        private void CategoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= CategoryData.Rows.Count)
                return;

            DataGridViewRow row = CategoryData.Rows[e.RowIndex];

            if (row.Cells["c_category_id"].Value != DBNull.Value)
            {
                txtBox_Name.Text = row.Cells["c_category_name"].Value?.ToString();
                int typeId = Convert.ToInt32(row.Cells["c_type_id"].Value);

                // Fetch c_type_name based on c_type_id
                string typeName = CategoryController.GetTypeName(typeId);
                cmb_type.Text = typeName;  // Set combo box text

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["c_date_created"].Value);
            }
            else
            {
                MessageBox.Show("Empty Row Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetTypeId(string typeName)
        {
            try
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT c_type_id FROM t_types WHERE c_type_name = @type_name", con))
                {
                    cmd.Parameters.AddWithValue("@type_name", typeName);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("Type not found.");
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtBox_Name.Text;
            string typeName = cmb_type.Text;
            int categoryTypeId = GetTypeId(typeName);

            if (categoryTypeId == -1)
            {
                MessageBox.Show("Invalid category type. Please select a valid type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO t_categories (c_category_name, c_user_id, c_type_id, c_is_active, c_date_created) VALUES (@name, @userid, @type, @isActive, @date)", con))
            {
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", categoryName);
                    cmd.Parameters.AddWithValue("@type", categoryTypeId);
                    cmd.Parameters.AddWithValue("@userid", 1);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@isActive", true);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    CategoryController.LoadData(ref CategoryData);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
