public class Car
{
    public Car(string make, string model, int year,
        double fuelQuantity, double fuelConsumption,
        Engine engine, Tire[] tires)
    {
        Make = make;
        Model = model;
        Year = year;
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
        Engine = engine;
        Tires = tires;
    }

    public string Make
    {
        get; set;
    }
    public string Model
    {
        get; set;
    }
    public int Year
    {
        get; set;
    }
    public double FuelQuantity
    {
        get; set;
    }
    public double FuelConsumption
    {
        get; set;
    }
    public Engine Engine
    {
        get; set;
    }
    public Tire[] Tires
    {
        get; set;
    }

    public void Drive(double distance)
    {
        double neededFuel = (distance / 100) * FuelConsumption;

        if (FuelQuantity >= neededFuel)
            FuelQuantity -= neededFuel;
    }
}