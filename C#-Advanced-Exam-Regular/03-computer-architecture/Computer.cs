using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model
        {
            get; set;
        }

        public int Capacity
        {
            get; set;
        }

        public List<CPU> Multiprocessor
        {
            get; private set;
        }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(c => c.Brand == brand);

            if (cpu == null)
            {
                return false;
            }

            Multiprocessor.Remove(cpu);
            return true;
        }

        public CPU MostPowerful()
        {
            return Multiprocessor
                .OrderByDescending(c => c.Frequency)
                .FirstOrDefault();
        }

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(c => c.Brand == brand);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {Model}:");

            foreach (CPU cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
