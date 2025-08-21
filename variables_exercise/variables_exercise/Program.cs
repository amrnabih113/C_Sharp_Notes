using System;

namespace VariablesExercise
{
    class Program
    {
        /*
         * Exercise: Create a console app that asks the user for full name,
         * birth year, and current year, then calculates
         * the user's age and prints a message like:
         * Hello John Doe, you are 25 years old.
         */
        static void Main(string[] args)
        {      
            Console.WriteLine("Please enter your full name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Please enter your birth year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current year:");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            int age = currentYear - birthYear;

            Console.WriteLine($"Hello {fullName}, you are {age} years old.");

            Console.ReadKey();

        }
    }
}