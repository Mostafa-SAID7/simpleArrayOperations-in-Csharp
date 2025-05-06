using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of integers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Print the elements of the array
            Console.WriteLine("Array elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Calculate the sum of the array elements
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum of array elements: {sum}");
        }
    }
}