public class StartUp
{
    static void Main()
    {
        List<Tire[]> tires = new List<Tire[]>();
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();

        // TIRES
        while (true)
        {
            var command = Console.ReadLine();

            if (command == "No more tires")
                break;

            var parts = command.Split();

            var tireComplect = new Tire[]
            {
                new Tire(int.Parse(parts[0]), double.Parse(parts[1])),
                new Tire(int.Parse(parts[2]), double.Parse(parts[3])),
                new Tire(int.Parse(parts[4]), double.Parse(parts[5])),
                new Tire(int.Parse(parts[6]), double.Parse(parts[7])),
            };

            tires.Add(tireComplect);
        }


        // ENGINES
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Engines done")
                break;

            string[] parts = input.Split();
            int hp = int.Parse(parts[0]);
            double cc = double.Parse(parts[1]);

            engines.Add(new Engine(hp, cc));
        }

        // CARS
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Show special")
                break;

            string[] parts = input.Split();

            string make = parts[0];
            string model = parts[1];
            int year = int.Parse(parts[2]);
            double fuelQuantity = double.Parse(parts[3]);
            double fuelConsumption = double.Parse(parts[4]);
            int engineIndex = int.Parse(parts[5]);
            int tiresIndex = int.Parse(parts[6]);

            if (engineIndex < 0 || engineIndex >= engines.Count)
                continue;
            if (tiresIndex < 0 || tiresIndex >= tires.Count)
                continue;

            Car car = new Car(make, model, year, fuelQuantity, fuelConsumption,
                              engines[engineIndex], tires[tiresIndex]);

            cars.Add(car);
        }

        // SPECIAL CARS
        var specialCars = cars
            .Where(c => c.Year >= 2017)
            .Where(c => c.Engine.HorsePower > 330)
            .Where(c =>
            {
                double sum = c.Tires.Sum(t => t.Pressure);
                return sum > 9 && sum < 10;
            })
            .ToList();

        foreach (var car in specialCars)
        {
            car.Drive(20);

            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
            Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
        }
    }
}
