using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class FindUniqueCommonValues
    {
        public static void FindUniqueCommonValuesFunc(string[] args)
        {
            Console.Write("Enter the first array of integers, separated by spaces: ");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter the second array of integers, separated by spaces: ");
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] common = array1.Intersect(array2).Distinct().ToArray();

            Console.WriteLine("Common elements without repetitions:");
            foreach (int element in common)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
