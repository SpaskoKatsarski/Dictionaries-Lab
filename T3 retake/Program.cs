using System;
using System.Collections.Generic;

namespace T3_retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonymWord = Console.ReadLine();

                if (synonyms.ContainsKey(word))
                {
                    synonyms[word].Add(synonymWord);
                }
                else
                {
                    //synonyms[word] = new List<string> { synonymWord };
                    synonyms.Add(word, new List<string> { synonymWord });
                }
            }

            foreach (KeyValuePair<string, List<string>> word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
