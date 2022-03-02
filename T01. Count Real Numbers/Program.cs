using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            SortedDictionary<int, int> consequence = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (consequence.ContainsKey(numbers[i]))
                {
                    consequence[numbers[i]]++;
                }
                else
                {
                    consequence.Add(numbers[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> number in consequence)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
