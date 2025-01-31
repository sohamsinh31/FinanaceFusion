using FinanceFusion.Forms;

namespace FinanceFusion;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        // ApplicationConfiguration.Initialize();
        Application.Run(new DashboardForm());


        // Check if user is remembered
        // if (Properties.Settings.Default.IsRemembered && !string.IsNullOrEmpty(Properties.Settings.Default.UserEmail))
        // {
        //     // Validate stored user data before logging in
        //     if (DatabaseHelper.ValidateUserExists(Properties.Settings.Default.UserEmail))
        //     {
        //         Application.Run(new DashboardForm());
        //         return;
        //     }
        //     else
        //     {
        //         // If invalid, reset stored credentials
        //         Properties.Settings.Default.IsRemembered = false;
        //         Properties.Settings.Default.UserEmail = "";
        //         Properties.Settings.Default.Save();
        //     }
        // }

        // // Show login form if no stored credentials or validation failed
        // Application.Run(new LoginForm(""));
    }    
}