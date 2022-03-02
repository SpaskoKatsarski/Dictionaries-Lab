using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLower())
                .ToList();

            Dictionary<string, int> wordsDic = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string currWord = words[i];

                if (wordsDic.ContainsKey(currWord))
                {
                    wordsDic[currWord] += 1;
                }
                else
                {
                    wordsDic.Add(currWord, 1);
                }
            }

            List<string> oddOccurrences = wordsDic
                .Where(word => word.Value % 2 != 0)
                .Select(w => w.Key)
                .ToList();

            Console.WriteLine(string.Join(' ', oddOccurrences));
        }
    }
}
