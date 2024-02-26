using System;
namespace EventAssignment
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine($"{HelloFriend}");
        }

        public static string HelloFriend()
        {
            return "Hello my friend";
        }
    }
}