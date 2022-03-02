using System;
using System.Collections.Generic;

namespace T._03_Synonims
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int couples = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymList = new Dictionary<string, List<string>>();

            for (int i = 0; i < couples; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonymList.ContainsKey(word))
                {
                    synonymList[word].Add(synonym);
                }
                else
                {
                    synonymList.Add(word, new List<string>(){synonym});
                }
            }

            foreach (var word in synonymList)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
