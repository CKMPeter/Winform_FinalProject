using System.Diagnostics.Eventing.Reader;

namespace FinalProject_WinForm
{
    static class Program
    {
        public static FormEntry logIn;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// public string backgroundColor = "60, 100, 159";
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of FormEntry
            logIn = new FormEntry();

            // Run the application with FormEntry as the main form
            Application.Run(logIn);
        }
    }
}