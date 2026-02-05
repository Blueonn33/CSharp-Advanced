namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weigth = int.Parse(input[3]);
                string type = input[4];

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(type, weigth);

                Tire[] tires = new Tire[4];

                for (int j = 0; j < 4; j++)
                {
                    double tirePressure = double.Parse(input[5 + j * 2]);
                    int tireAge = int.Parse(input[5 + j * 2 + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires[j] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars[i] = car;
            }

            string command = Console.ReadLine();
            Car[] filteredCars;

            if (command == "fragile")
            {
                filteredCars = cars
                    .Where(car => car.Cargo.Type == "fragile" && car.SingleTireUnderPressure(1)).ToArray();
            }
            else
            {
                filteredCars = cars
                    .Where(car => car.Cargo.Type == "flammable" && car.Engine.Power > 250).ToArray();
            }

            foreach (Car car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}