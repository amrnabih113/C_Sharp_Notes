using System;

namespace DataTypes_excersise
{
    class Program
    {
        /*
         * Exercise: Write a program that calculates the BMI (Body Mass Index):
         * Ask the user for weight (kg) and height (m)
         * BMI = weight / (height * height)
         * Print BMI with 2 decimal points and classify as Underweight, Normal, Overweight, or Obese
         */
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.Write("Enter your weight in kg: ");
            while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
            {
                Console.Write("Invalid input. Please enter a valid weight in kg: ");
            }
            Console.Write("Enter your height in meters: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.Write("Invalid input. Please enter a valid height in meters: ");
            }
            bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");


        }
    }
}