using System;
using System.Threading.Tasks;
using AutoUpdaterDotNET;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            const String updateUrl = "https://github.com/radu-andrei-oprea/TestAppUpdates/version.xml";
            AutoUpdater.Start(updateUrl);


            Console.WriteLine("Eight change:");
            const string Value = "Added AutoUpdater components";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
        }

       
    }
}
