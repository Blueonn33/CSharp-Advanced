namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var car = new Car()
            {
                Make = "Aston Martin",
                Model = "Vulcan",
                Year = 2026,
                FuelQuantity = 100,
                FuelConsumption = 10
            };
        }
    }
}