namespace Data_Clean_Tool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Thread.CurrentThread.Name = "UI Thread";
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}