using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Student
    {
        public Student(string name, int age, bool isActive)
        {
            this.Name = name;
            this.Age = age;
            this.IsActive = isActive;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsActive { get; set; }

        public void SayName()
        {
            Console.WriteLine(this.Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Ivan", 12, true);
            Student st2 = new Student("Yordan", 14, false);
            Student st3 = new Student("Spasko", 11, true);
            Student st4 = new Student("Go6o", 17, false);
            Student st5 = new Student("Petar", 10, true);

            List<Student> allStudents = new List<Student>
            {
                st1,
                st2,
                st3,
                st4,
                st5

            };

            // Everyone that is above 14:
            List<string> studentAbove14 = allStudents
                    .Where(student => student.Age > 14)
                    .Select(student => student.Name)
                    .ToList();

            Console.WriteLine(string.Join(" ", studentAbove14));

            // Are there any inactive students?
            bool areThereAnyInactiveStudents = allStudents
                .Where(s => !s.IsActive)
                .ToList()
                .Count > 0;

            Console.WriteLine(areThereAnyInactiveStudents);

            // Get the average age of the students:
            double averageAge = allStudents
                .Select(x => x.Age)
                .Average();

            Console.WriteLine(averageAge);

            // Say name:
            //allStudents[1].SayName();


            //SortedDictionary<string, int> people = new SortedDictionary<string, int>();

            //people.Add("Ivan", 15);
            //people.TryAdd("Ivan", 15);
            //people["Spasko"] = 16;
            //// new value, but with Add method won't work
            //people["Spasko"] = 10;

            //Console.WriteLine(people.ContainsKey("Spasko"));

            //foreach (KeyValuePair<string, int> person in people)
            //{
            //    Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
            //}

            //SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>()
            //{
            //    ["Jordan"] = "47",
            //    ["Nike"] = "32",
            //    ["New Shoes"] = "24"
            //};
        }
    }
}
