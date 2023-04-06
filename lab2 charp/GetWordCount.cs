using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_charp
{
    internal class GetWordCount
    {
        public static void GetWordCountFunc(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"The sentence '{sentence}' contains {wordCount} words.");

            Console.ReadLine();
        }
    }
}
