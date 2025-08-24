namespace Delegates
{
    class Program
    {
      
        public delegate void MathOperation<in T>(T a, T b);

        static void Main(string[] args)
        {
            MathOperation<int> operation = (x,y) => Console.WriteLine($"Adding {x} + {y} = {x+y}");
            int[] nums = { 10, 5 };
             
            operation(nums[0], nums[1]);
            Console.WriteLine("=====================================");
            operation += Subtract;
            operation(nums[0], nums[1]);
            Console.WriteLine("=====================================");
            operation += Multiply;
            operation(nums[0], nums[1]);
            Console.WriteLine("=====================================");
            operation += Divide;
            operation(nums[0], nums[1]);
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"Adding {a} + {b} = {a + b}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Substracting {a} - {b} = {a - b}");
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplying {a} * {b} = {a * b}");
        }

        public static void Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            Console.WriteLine($"Dividing {a} / {b} = {a / b}");
        }
    }
    
}