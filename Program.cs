using System;

namespace StaticClass
{
    public static class Helper
    {
        public static string FullName(string FirstName, string LastName)
        {
            return $"Full Name: {FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("A class with static keyword that contains only static members is defined as static class. A static class cannot be instantiated.");
            Console.WriteLine();

            Console.Write(Helper.FullName("Stuart", "Shepherd"));
            Console.WriteLine();
        }
    }
}