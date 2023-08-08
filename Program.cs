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
            Console.WriteLine("11th change:");
            const string Value = "fixed links again";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
            
        }
    }
}
