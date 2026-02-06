using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new();
            List<Car> cars = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);

                int? displacement = null;
                string? efficiency = null;

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int disp))
                        displacement = disp;
                    else
                        efficiency = input[2];
                }
                else if (input.Length == 4)
                {
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];
                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engineModel = input[1];

                int? weight = null;
                string? color = null;

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int w))
                        weight = w;
                    else
                        color = input[2];
                }
                else if (input.Length == 4)
                {
                    weight = int.Parse(input[2]);
                    color = input[3];
                }

                Engine engine = engines.First(e => e.Model == engineModel);
                cars.Add(new Car(model, engine, weight, color));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
