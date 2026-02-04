namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public double FuelQuantity
        {
            get; set;
        }
        public double FuelConsumption
        {
            get; set;
        }

        public void Drive(double distance)
        {
            double consumption = (distance / 100) * FuelConsumption;

            if (consumption <= FuelQuantity)
            {
                FuelQuantity -= consumption;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return @$"Make: {this.Make}
Model: {this.Model}
Year: {this.Year}
Fuel: {this.FuelQuantity:F2}";
        }
    }
}
