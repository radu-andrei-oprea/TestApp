using System;
using AutoUpdaterDotNET;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            const String updateUrl = "https://github.com/radu-andrei-oprea/TestAppUpdates/releases/tag/Latest/version.xml";
            AutoUpdater.Start(updateUrl);


            Console.WriteLine("Eight change:");
            const string Value = "Added AutoUpdater components";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
        }

       
    }
}
