namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            var tires = new Tire[4]
            {
                new Tire(2025, 2.2),
                new Tire(2025, 2.2),
                new Tire(2025, 2.3),
                new Tire(2025, 2.3)
            };

            var engine = new Engine(830, 10.0);
            var aston = new Car("Aston Martin", "DB11", 2025, 100, 12, engine, tires);
        }
    }
}