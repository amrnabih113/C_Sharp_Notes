namespace Methods_exercise
{
    class Program
    {
        /*
         * Exercise:
         * Create a program with these methods:
         * IsPrime(int num) → returns true if number is prime
         * Factorial(int num) → returns factorial
         * Fibonacci(int n) → returns first n Fibonacci numbers as an array
         * Test all methods in Main().
         * Goal: Method design, return types, recursion/loops.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("First is Prime Function");
            Console.Write("Enter the number :");
            int x = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(x))
            {
                Console.WriteLine($"{x} is a prime number\n=========================================");
            }else
            {
                Console.WriteLine($"{x} is not a prime number\n=========================================");
            }

            Console.WriteLine("Second is Factorial Function");
            Console.Write("Enter the number :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Factorial of {y} = {Factorial(y)}\n=========================================");

            Console.WriteLine("Second is Fibonacci Function");
            Console.Write("Enter the number :");
            int z = Convert.ToInt32(Console.ReadLine());
            int[] feb = Fibonacci(z);

            for (int i = 0; i < feb.Length; i++)
            {
                Console.WriteLine(feb[i]);
            }

        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true; 
        }

        static int Factorial(int num) 
        {
            if (num <= 1)
            { return 1; }
            return num * Factorial(num - 1);
        }

        static int[] Fibonacci(int n)
        {
            int[] result = new int[n];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < n; i++) //0,1, 
            {
                result[i] = result[i - 1] + result[i-2];
            }
            return result;
        }



    }
}