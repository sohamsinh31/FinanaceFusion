using Npgsql;

namespace FinanceFusion.Feeders
{
    public class DBFeeder
    {
        private const string connectionString = "Server=cipg01;Port=5432;Database=intern088;User Id=postgres;Password=123456;";
        public static NpgsqlConnection DBCon = new NpgsqlConnection(connectionString);
    }
}