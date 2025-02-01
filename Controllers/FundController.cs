using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// 
using FinanceFusion.Models;
using FinanceFusion.Helpers;

namespace FinanceFusion.Controllers
{
    public class FundController
    {
        static string connectionString = "Server=cipg01;Port=5432;Database=intern088;User Id=postgres;Password=123456;";
        public static void LoadCategories(ref ComboBox CBox, int type)
        {
            CBox.Items.Clear();
            try
            {
                using (NpgsqlConnection DBCon = new NpgsqlConnection(connectionString))
                {
                    DBCon.Open();
                    string query = $"SELECT c_category_id, c_category_name FROM t_categories WHERE c_type_id = {type}";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBCon))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            CBox.DataSource = dataTable;
                            CBox.DisplayMember = "c_category_name";
                            CBox.ValueMember = "c_category_id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadTables(ref DataGridView dgv, int type)
        {
            try
            {
                using (NpgsqlConnection DBCon = new NpgsqlConnection(connectionString))
                {
                    DBCon.Open();
                    string query = @$"
                    SELECT 
                    t.c_transaction_id AS SRN,
                    t.c_amount AS Amount,
                    t.c_description AS Description,
                    CAST(t.c_date_created AS DATE) AS Date,
                    TO_CHAR(t.c_date_created, 'HH24:MI:SS') AS Time,
                    c.c_category_name AS Type
                    FROM 
                    t_transactions AS t
                    JOIN
                    t_categories AS c
                    ON
                    c.c_category_id = t.c_category_id
                    WHERE
                    c.c_type_id = {type}
                    ";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBCon))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void InsertTransaction(TransactionModel transaction)
        {
            try
            {
                using (NpgsqlConnection DBCon = new NpgsqlConnection(connectionString))
                {
                    DBCon.Open();
                    string query = @"
                INSERT INTO t_transactions (c_amount, c_description, c_date_created, c_category_id, c_user_id) 
                VALUES (@amount, @description, @date, @categoryId, @uid)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBCon))
                    {

                        Guid guid = new Guid(SessionHelper.userId);
                        cmd.Parameters.AddWithValue("@amount", transaction.Amount);
                        cmd.Parameters.AddWithValue("@description", transaction.Description);
                        cmd.Parameters.AddWithValue("@date", transaction.CreatedDateTime);
                        cmd.Parameters.AddWithValue("@categoryId", transaction.CategoryId);
                        cmd.Parameters.AddWithValue("@uid", guid);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void UpdateTransaction(TransactionModel transaction)
        {
            try
            {
                using (NpgsqlConnection DBCon = new NpgsqlConnection(connectionString))
                {
                    DBCon.Open();
                    string query = @"
                UPDATE t_transactions 
                SET c_amount = @amount, 
                    c_description = @description, 
                    c_date_created = @date, 
                    c_category_id = @categoryId
                WHERE c_transaction_id = @transactionId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBCon))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transaction.Id);
                        cmd.Parameters.AddWithValue("@amount", transaction.Amount);
                        cmd.Parameters.AddWithValue("@description", transaction.Description);
                        cmd.Parameters.AddWithValue("@date", transaction.CreatedDateTime);
                        cmd.Parameters.AddWithValue("@categoryId", transaction.CategoryId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void DeleteTransaction(int transactionId)
        {
            try
            {
                using (NpgsqlConnection DBCon = new NpgsqlConnection(connectionString))
                {
                    DBCon.Open();
                    string query = "DELETE FROM t_transactions WHERE c_transaction_id = @transactionId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBCon))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
