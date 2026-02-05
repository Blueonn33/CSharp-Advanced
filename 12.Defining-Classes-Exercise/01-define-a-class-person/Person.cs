using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        private string name;
        private int age;

        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }
    }

    public class Family
    {
        public Family()
        {
            family = new List<Person>();
        }

        private List<Person> family;

        public void AddMember(Person person)
        {
            family.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = family.OrderByDescending(p => p.Age)
                .FirstOrDefault();

            return oldest;
        }

        public List<Person> OpinionPoll()
        {
            List<Person> people = new List<Person>();

            people = family
                .OrderBy(p => p.Name)
                .Where(p => p.Age > 30)
                .ToList();

            return people;
        }

        public List<Person> FilterMembers(Func<Person, bool> filter)
        {
            List<Person> filteredMembers = new();

            foreach (var person in family)
            {
                if (filter(person))
                {
                    filteredMembers.Add(person);
                }
            }

            return filteredMembers;
        }

        public List<Person> SortMembers(List<Person> members)
        {
            return members.OrderBy(m => m.Name).ToList();
        }

        public void PrintMembers(int ageTreshold)
        {
            List<Person> filteredMembers = FilterMembers(p => p.Age > ageTreshold);

            filteredMembers = SortMembers(filteredMembers);

            foreach (var person in filteredMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

        //public Person GetOldestMember(List<Person> family)
        //{
        //    Person oldestPerson = new Person()
        //    {
        //        Name = " ",
        //        Age = 0
        //    };

        //    foreach (Person person in family)
        //    {
        //        if (person.Age > oldestPerson.Age)
        //        {
        //            oldestPerson.Name = person.Name;
        //            oldestPerson.Age = person.Age;
        //        }
        //    }

        //    return oldestPerson;
        //}
    }
}
