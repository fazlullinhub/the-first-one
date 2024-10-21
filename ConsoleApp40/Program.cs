using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
            }
            Console.WriteLine("\n You entered numbers: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            FindMaxElement(numbers);
            IncreasingSorting(numbers);
            
            FindMinElement(numbers);
            DecreasingSorting(numbers);

            Console.WriteLine("\nSorted (Ascending): ");

            Console.WriteLine("\nSorted (Descending): ");
           
            void FindMaxElement(int[] numbers)
            {
                var max = numbers.Max();
                Console.WriteLine($"Max element: {max}");
            }
            void FindMinElement(int[] numbers)
            {
                var min = numbers.Min();
                Console.WriteLine($"Min element: {min}");
            }
            void IncreasingSorting(int[] numbers)
            {
                Array.Sort(numbers);

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            void DecreasingSorting(int[] numbers)
            {
                var orderedNumbers = numbers.OrderByDescending(n => n);
                foreach (int number in orderedNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

    }
}
