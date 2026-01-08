using System.Collections;
using System.Data;

namespace _08_traffic_jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int passedCars = 0;

            Queue<string> cars = new();
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    int count = Math.Min(n, cars.Count);

                    for (int i = 0; i < count; i++)
                    {
                        string car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
