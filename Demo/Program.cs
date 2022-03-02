using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> people = new SortedDictionary<string, int>();

            people.Add("Ivan", 15);
            people.TryAdd("Ivan", 15);
            people["Spasko"] = 16;
            // new value, but with Add method won't work
            people["Spasko"] = 10;

            Console.WriteLine(people.ContainsKey("Spasko"));

            foreach (KeyValuePair<string, int> person in people)
            {
                Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
            }

            //SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>()
            //{
            //    ["Jordan"] = "47",
            //    ["Nike"] = "32",
            //    ["New Shoes"] = "24"
            //};
        }
    }
}
