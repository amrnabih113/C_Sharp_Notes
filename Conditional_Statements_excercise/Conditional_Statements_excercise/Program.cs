namespace Conditional_Statements_excercise
{
    class Program
    {
        /* Exercise: Create a program to check if a year is a leap year:
            Leap year rules: divisible by 4, not divisible by 100 unless divisible by 400
            Extra: Let the user enter multiple years until they type "exit".
            Goal: Nested if-else, loops, boolean logic.
         */
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
                int year;
                Console.WriteLine("Enter a year to check if it is a leap year:");
                year = Convert.ToInt32(Console.ReadLine());

                bool isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                if (isLeap)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
                Console.WriteLine("Do you want to check another year? (yes/exit) ");
                choice = Console.ReadLine().ToLower();
            } while(choice != "exit");

        }
    }
}