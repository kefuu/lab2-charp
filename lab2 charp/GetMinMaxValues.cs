using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class GetMinMaxValues
    {
        public static void GetMinMaxValuesFunc(string[] args)
        {
            Console.Write("Enter the number of rows in the array: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns in the array: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }

                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");

            Console.ReadLine();
        }
    }
}
