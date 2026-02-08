using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class CatYearComparer : IComparer<Cat>
    {
        public int Compare(Cat? first, Cat? second)
        {
            return first.Age.CompareTo(second.Age);
        }
    }
}
