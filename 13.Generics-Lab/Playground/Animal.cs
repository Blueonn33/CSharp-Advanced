using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Animal
    {
        public string Type { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"I am a {this.Type}");
        }
    }
}
