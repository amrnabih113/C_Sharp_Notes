using System;

namespace Operators_excersise
{
    class Program
    {
        /*
         * Exercise: Write a mini calculator that asks for two numbers and an operator (+, -, *, /, %),
         * then prints the result.
         * Extra: Handle division by zero using a conditional operator.
         * Goal: Operators, conditional logic, input validation.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /, %):");
            string op = Console.ReadLine();
            double result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = (num2 != 0) ? num1 / num2 : double.NaN; 
                    break;
                case "%":
                    result = (num2 != 0) ? num1 % num2 : double.NaN; 
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }
            if (double.IsNaN(result))
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"The result of {num1} {op} {num2} is: {result}");
            }

        }
    }
}