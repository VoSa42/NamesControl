using System;

namespace NamesControl
{
    public class Program
    {
        // MAUI GUI is ran if 'mauiApp' is true, console GUI for developing otherwise
        public static bool mauiApp = false;

        static void Main(string[] args)
        {
            if (mauiApp)
            {
                Console.WriteLine("The winndow GUI is not implemented yet.");
            }
            else
            {
                consoleGui.TerminalRun.Run();
            }
        }
    }
}