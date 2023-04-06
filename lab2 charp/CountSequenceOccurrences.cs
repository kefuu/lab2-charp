using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class CountSequenceOccurrences
    {
        public static void CountSequenceOccurrencesFunc(string[] args)
        {
            Console.Write("Enter an array of integers, separated by spaces: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter the first number of the sequence: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number of the sequence: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number of the sequence: ");
            int third = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == first && numbers[i + 1] == second && numbers[i + 2] == third)
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of repetitions of the sequence: {count}");

            Console.ReadLine();
        }
    }
}
