using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class CountValuesLessThanThreshold
    {
        public static void CountValuesLessThanThresholdFunc(string[] args)
        {
            Console.Write("Enter an array of integers, separated by spaces: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter a threshold value: ");
            int threshold = int.Parse(Console.ReadLine());

            int count = numbers.Count(n => n < threshold);

            Console.WriteLine($"Number of values less than {threshold}: {count}");

            Console.ReadLine();
        }
    }
}
