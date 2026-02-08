namespace PeopleComparable
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                //string town = input[2];
                //int id = int.Parse(input[3]);

                people.Add(new Person(name, age, "", -1));
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(people.Count);
        }
    }
}
