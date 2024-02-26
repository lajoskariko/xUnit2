using System;
using System.Diagnostics.Contracts;
namespace xUnitTesting
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine($"{Hello()}");
        }

        public static string Hello()
        {
            return "Hello my friend";
        }
    }
}