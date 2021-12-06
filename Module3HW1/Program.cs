using System;

namespace Module3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList<Person> people = new CustomList<Person>();

            Console.WriteLine("Add:\n");

            people.Add(new Person { Name = "Mark", Age = 66 });
            people.Add(new Person { Name = "Paul", Age = 18 });
            people.Add(new Person { Name = "Liam", Age = 55 });
            people.Add(new Person { Name = "Oliver", Age = 17 });
            people.Add(new Person { Name = "Noah", Age = 8 });

            foreach (var item in people)
            {
                var person = item as Person;
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine("\nAddRange:\n");

            Person liam = new Person { Name = "Liam", Age = 9 };

            Person[] peopleArray = new Person[]
            {
                liam,
                new Person { Name = "Elijah", Age = 16 },
                new Person { Name = "James", Age = 32 },
                new Person { Name = "Alexander", Age = 44 }
            };

            people.AddRange(peopleArray);

            foreach (var item in people)
            {
                var person = item as Person;
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine($"\nRemove:");
            Console.WriteLine($"Output: {people.Remove(liam)}\n");

            foreach (var item in people)
            {
                var person = item as Person;
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine($"\nRemoveAt: {people.GetCount() - 1}\n");

            people.RemoveAt(people.GetCount() - 1);

            foreach (var item in people)
            {
                var person = item as Person;
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine($"\nSort:\n");

            people.Sort();

            foreach (var item in people)
            {
                var person = item as Person;
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
