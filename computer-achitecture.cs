using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU (string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;    
        }

        public string Brand {get;set;}
        public int Cores {get;set;}
        public double Frequency {get;set;}

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Brand} CPU:");
            sb.AppendLine($"Cores: {Cores}");
            sb.AppendLine($"Frequency: {Frequency:F1} GHz");
        }
    }

    public class Computer
    {
        public Computer (string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();    
        }

        public string Model {get;set;}
        public int Capacity {get;set;}
        public List<CPU> Multiprocessor;

        public int Count
        {
            get
            {
                return Multiprocessor.Count;
            }
        }

        public void Add (CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove (string brand)
        {
            return Remove(Multiprocessor.FirstOrDefault(c => c.Brand == brand));
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(c => c.Frequency).First();
        }

        public CPU GetCPU (string brand)
        {
            return Multiprocessor.First(c => c.Brand == brand);
        }

        public void Report()
        {
            Console.WriteLine($"CPUs in the Computer {Model}:");

            foreach (var cpu in Multiprocessor)
            {
                cpu.ToString();
            }
        }
    }
}
