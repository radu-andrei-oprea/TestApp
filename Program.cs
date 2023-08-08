﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutoUpdaterDotNET;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // generic link to latest release
            const String latestURL = $"https://api.github.com/radu-andrei-oprea/TestAppUpdates/releases/latest/download/version.xml";

            AutoUpdater.Start(latestURL);

            // print text
            Console.WriteLine("Ninth change:");
            const string Value = "AutoUpdate prelude";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
            
            
            //AutoUpdater.Start(updateUrl);
        }

       
    }
}
