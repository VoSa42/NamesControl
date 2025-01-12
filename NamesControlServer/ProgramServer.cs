using System;
using System.Net;

namespace NamesControlServer
{
    public class ProgramServer
    {
        static async Task Main(string[] args)
        {
            await ServerBackend.RunServer.Run();
        }
    }
}