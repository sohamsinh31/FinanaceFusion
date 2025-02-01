using System;
using System.Data;
using System.Windows.Forms; // Required for MessageBox
using Npgsql; // PostgreSQL library

namespace FinanceFusion.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString = ConfigHelper.GetConnectionString();

        /// <summary>
        /// Creates and returns an open database connection.
        /// Ensures connection is only opened if it's not already open.
        /// </summary>
        private static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            return connection; // Connection will be opened inside `using` statements
        }

        /// <summary>
        /// Executes a SQL query and returns a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        /// <summary>
        /// Executes a non-query SQL command (INSERT, UPDATE, DELETE).
        /// </summary>
        public static int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes a SQL command and returns a single scalar value.
        /// </summary>
        public static object ExecuteScalar(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Executes a SQL command to validate user login.
        /// </summary>
        public static bool ValidateLogin(string email, string password, out string userId)
        {
            userId = string.Empty;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = @"
                    SELECT c_user_id 
                    FROM t_users 
                    WHERE c_email = @c_email AND c_password = @c_password AND c_is_active = TRUE";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_email", email);
                        cmd.Parameters.AddWithValue("@c_password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userId = result.ToString();
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Checks if a user exists based on email.
        /// </summary>
        public static bool ValidateUserExists(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM t_users WHERE c_email = @c_email AND c_is_active = TRUE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@c_email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
