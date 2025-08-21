namespace LoopsExercise
{
    class Program
    {
        /* Exercise: Create a program that prints a pyramid pattern of stars for a given number of rows:
         *                 *
                          ***
                         *****
                        *******
         */
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number of rows for the pyramid: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                // Print the spaces
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                // Print the stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                // Move to the next line
                Console.WriteLine();
            }
        }
    }



}