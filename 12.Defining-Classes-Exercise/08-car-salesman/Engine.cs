using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(string model, int power, int? displacement = null, string? efficiency = null)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model
        {
            get; set;
        }
        public int Power
        {
            get; set;
        }
        public int? Displacement
        {
            get; set;
        }
        public string? Efficiency
        {
            get; set;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {(Displacement?.ToString() ?? "n/a")}");
            sb.AppendLine($"    Efficiency: {(Efficiency ?? "n/a")}");

            return sb.ToString().TrimEnd();
        }
    }
}