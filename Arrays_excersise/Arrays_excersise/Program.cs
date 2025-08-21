namespace Arrays_excersise
{
    class Program
    {
         /* Exercise:
            Ask the user to enter 10 numbers
            Store them in an array
            Find max, min, sum, average, and second largest number
            Goal: Arrays, loops, conditional statements, basic algorithmic thinking.
          */
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine("Enter the 10 Nnumbers");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(nums);
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double average = sum / (double)nums.Length;
            int secondLargest = nums[nums.Length - 2];
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Second Largest: {secondLargest}");
        }
    }
}