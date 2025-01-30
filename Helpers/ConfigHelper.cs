using Microsoft.Extensions.Configuration;
using System.IO;

namespace FinanceFusion.Helpers
{
    public static class ConfigHelper
    {
        public static IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string GetConnectionString()
        {
            return GetConfiguration().GetConnectionString("DefaultConnection");
        }
    }
}