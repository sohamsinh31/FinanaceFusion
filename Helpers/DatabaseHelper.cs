using System;
using System.Data;
using Npgsql; // PostgreSQL library

namespace FinanceFusion.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString = ConfigHelper.GetConnectionString();

        /// <summary>
        /// Creates and returns an open database connection.
        /// </summary>
        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Executes a SQL query and returns a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
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

        /// <summary>
        /// Executes a non-query SQL command (INSERT, UPDATE, DELETE).
        /// </summary>
        public static int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executes a SQL command and returns a single scalar value.
        /// </summary>
        public static object ExecuteScalar(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
    }
}