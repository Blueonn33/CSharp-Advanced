using System.Threading.Channels;

namespace People
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new();
            string command = Console.ReadLine();
            int id = 0;

            while (command != "END")
            {
                string[] input = command.Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = string.Join(" ", input[2..]);

                Person person = new Person(name, age, town, id++);
                people.Add(person);

                command = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person currentPerson = people[n - 1];

            Person[] equalPeople = people
                .Where(p => p.CompareTo(currentPerson) == 0)
                .ToArray();

            if (equalPeople.Length == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople.Length} {people.Count - equalPeople.Length} {people.Count}");
            }
        }
    }
}
