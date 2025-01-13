namespace NamesControlServer
{
    /// <summary>
    /// The main server program.
    /// </summary>
    public class ProgramServer
    {
        /// <summary>
        /// The server main program.
        /// Runs asynchronous.
        /// </summary>
        static async Task Main(string[] args)
        {
            await ServerBackend.RunServer.Run();
        }
    }
}