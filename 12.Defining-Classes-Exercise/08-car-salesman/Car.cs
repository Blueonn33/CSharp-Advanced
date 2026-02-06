using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, int? weight = null, string? color = null)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model
        {
            get; set;
        }
        public Engine Engine
        {
            get; set;
        }
        public int? Weight
        {
            get; set;
        }
        public string? Color
        {
            get; set;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{Model}:");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine($"  Weight: {(Weight?.ToString() ?? "n/a")}");
            sb.AppendLine($"  Color: {(Color ?? "n/a")}");

            return sb.ToString().TrimEnd();
        }
    }
}