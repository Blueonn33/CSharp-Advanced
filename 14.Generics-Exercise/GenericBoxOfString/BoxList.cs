
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class BoxList<T>
    {
        public BoxList()
        {
            Data = new List<Box<T>>();
        }

        public List<Box<T>> Data { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            Box<T> temp = Data[firstIndex];
            Data[firstIndex] = Data[secondIndex];
            Data[secondIndex] = temp;
        }
    }
}
