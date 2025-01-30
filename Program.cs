using Dashbord;

namespace FundTransfer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new ExpanceView());
            // Application.Run(new IncomeView());
            //Application.Run(new ReportView());
            // Application.Run(new Dashboard());
            Application.Run(new LoginPage(""));
            // Application.Run(new RegistrationPage());
        }
    }
}