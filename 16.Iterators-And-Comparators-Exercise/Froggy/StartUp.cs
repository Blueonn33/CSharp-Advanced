using System.Threading.Channels;

namespace Froggy
{
    internal class StartUp
    { 
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(input);
            bool isFirst = true;

            foreach (var stone in lake)
            {
                if (isFirst)
                {
                    isFirst = false;
                    Console.Write($"{stone}");
                }
                else
                {
                    Console.Write($", {stone}");
                }
            }
        }
    }
}
