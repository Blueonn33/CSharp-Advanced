using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Cat : IComparable<Cat>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Cat? other)
        {
            //if (this.Age < other.Age)
            //{
            //    return -1;
            //}
            //else if (this.Age > other.Age)
            //{
            //    return 1;
            //}

            //return 0;

            return this.Name.CompareTo(other.Name);
            //return this.Age.CompareTo(other.Age);
        }
    }
}
