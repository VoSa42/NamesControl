namespace NamesControlClient
{
    internal static class ProgramClient
    {
        // WindowsForms GUI is ran if 'winFormsGui' is true,
        // console GUI for developing is ran otherwise
        public static bool winFormsGui = true;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (winFormsGui)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else
            {
                Console.WriteLine("The console GUI is not implemented yet.");
            }
        }
    }
}