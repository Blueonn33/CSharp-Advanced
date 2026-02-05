using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car (string model, double fuelAmount, double fuelComsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelComsumptionPerKilometer = fuelComsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelComsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelComsumptionPerKilometer;

            if (fuelNeeded > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                TravelledDistance += distance;
                FuelAmount -= fuelNeeded;
            }
        }
    }
}
