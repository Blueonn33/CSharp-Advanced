using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public int CompareTo(Box<T>? other)
        {
            return Value.CompareTo(other.Value);
        }

        //public bool IsGreater(T other)
        //{
        //    if (other.CompareTo(Value) > 1)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {Value}";
        }
    }
}
