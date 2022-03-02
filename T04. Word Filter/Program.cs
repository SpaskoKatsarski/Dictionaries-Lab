using System;
using System.Linq;

namespace T04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
