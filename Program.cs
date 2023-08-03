using System;
using System.Diagnostics;
using System.Reflection;
using Squirrel;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seventh change:");
            const string Value = "Moved to VS 2022";
            Console.WriteLine(Value);
            Console.WriteLine("\nPress any key to close...");
            _ = Console.ReadKey();
        }
    }
}
