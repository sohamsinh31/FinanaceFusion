using System.Data;
using FinanceFusion.Feeders;
using FinanceFusion.Models;
using Npgsql;

namespace FinanceFusion.Controllers
{
    class CategoryController
    {
        private static NpgsqlConnection con = DBFeeder.DBCon;
        public static void LoadData(ref DataGridView CategoryData)
        {
            const string query = @$"
            SELECT 
                c_category_id, 
                c_category_name, 
                c_type_id, 
                c_date_created, 
                c_date_updated, 
                c_is_active 
            FROM 
                t_categories
            ";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    CategoryData.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static void UpdateData(CategoryModel categoryModel)
        {
            const string query = @"
            UPDATE 
                t_categories 
            SET 
                c_category_name = @name, c_type_id = @type, c_date_updated = NOW() 
            WHERE 
                c_category_id = @id
            ";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", categoryModel.CategoryName);
                    cmd.Parameters.AddWithValue("@type", categoryModel.TypeId);
                    cmd.Parameters.AddWithValue("@id", categoryModel.Id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    con.Close();

                }
            }
        }

        public static void DeleteData(int categoryId)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM t_categories WHERE c_category_id = @id", con))
            {
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static string GetTypeName(int typeId)
        {
            string typeName = "";

            try
            {
                con.Open();
                const string query = @"
                SELECT 
                    c_type_name 
                FROM 
                    t_types
                WHERE
                    c_type_id = @type_id
                ";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@type_id", typeId);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            typeName = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return typeName;
        }
        public static void LoadType(ref ComboBox cmb_type)
        {
            try
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT c_type_name FROM t_types", con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_type.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}