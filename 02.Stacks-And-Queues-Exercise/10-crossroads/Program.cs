namespace _10_crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int windowSeconds = int.Parse(Console.ReadLine());
            bool isCrash = false;
            int passedCars = 0;

            Queue<string> cars = new();

            string command = "";

            while (command.ToLower() != "end")
            {
                command = Console.ReadLine().Trim();

                if (command.ToLower() == "green" && cars.Count > 0)
                {
                    int greenLight = greenLightSeconds;
                    int window = windowSeconds;
                    string car = cars.Dequeue();
                    passedCars++;
                    Queue<char> carSymbols = new(car);

                    while (greenLight > 0)
                    {
                        if (carSymbols.Count == 0)
                        {
                            if (cars.Count == 0)
                            {
                                break;
                            }

                            car = cars.Dequeue();
                            passedCars++;
                            carSymbols = new Queue<char>(car);
                        }

                        carSymbols.Dequeue();
                        greenLight--;
                    }

                    if (carSymbols.Count > 0)
                    {
                        while (window > 0 && carSymbols.Count > 0)
                        {
                            carSymbols.Dequeue();
                            window--;
                        }

                        if (carSymbols.Count > 0)
                        {
                            isCrash = true;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {carSymbols.Dequeue()}.");
                            break;
                        }
                    }
                }
                else if (command.ToLower() != "green" && command.ToLower() != "end")
                {
                    cars.Enqueue(command);
                }
            }

            if (!isCrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
