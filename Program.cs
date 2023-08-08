using System;
using System.Threading.Tasks;
using AutoUpdaterDotNET;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // generic link to latest release
            const String latestURL = $"https://github.com/radu-andrei-oprea/TestAppUpdates/releases/latest/download/version.xml";

            AutoUpdater.Start(latestURL);

            // print text
            Console.WriteLine("12th change:");
            const string Value = "possible versions fix";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
            
        }
    }
}
