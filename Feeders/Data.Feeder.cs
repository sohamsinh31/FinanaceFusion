using Npgsql;

namespace FundTransfer
{
    public class DBFeeder
    {
        public static string connectionString = "Server=cipg01;Port=5432;Database=intern088;User Id=postgres;Password=123456;";
        public static NpgsqlConnection DBCon = new NpgsqlConnection("Server=cipg01;port=5432;Database=intern088;UserId=postgres;Password=123456;");
    }
}