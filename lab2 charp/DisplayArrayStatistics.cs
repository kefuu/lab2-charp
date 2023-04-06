using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class DisplayArrayStatistics
    {
        public static void DisplayArrayStatisticsFunc(string[] args)
        {
            Console.Write("Enter an array of integers, separated by spaces: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = numbers.Distinct().Count();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Number of even elements: {evenCount}");
            Console.WriteLine($"Number of odd elements: {oddCount}");
            Console.WriteLine($"Number of unique elements: {uniqueCount}");

            Console.ReadLine();
        }
    }
}
