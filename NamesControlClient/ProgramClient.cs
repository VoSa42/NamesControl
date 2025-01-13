namespace NamesControlClient
{
    /// <summary>
    /// Main client program.
    /// </summary>
    internal static class ProgramClient
    {
        /// <summary>
        /// The main entry point for the client application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new NCForm());
        }
    }
}