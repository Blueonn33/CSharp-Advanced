namespace Tuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomTuple<string, string> nameAndAdress = new();
            string[] line = Console.ReadLine().Split();

            nameAndAdress.Item1 = line[0] + " " + line[1];
            nameAndAdress.Item2 = line[2];
            Console.WriteLine(nameAndAdress);

            CustomTuple<string, int> nameAndBeer = new();
            line = Console.ReadLine().Split();

            nameAndBeer.Item1 = line[0];
            nameAndBeer.Item2 = int.Parse(line[1]);
            Console.WriteLine(nameAndBeer);

            CustomTuple<int, double> numbers = new();
            line = Console.ReadLine().Split();

            numbers.Item1 = int.Parse(line[0]);
            numbers.Item2 = double.Parse(line[1]);
            Console.WriteLine(numbers);
        }
    }
}
