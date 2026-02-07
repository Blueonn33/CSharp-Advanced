using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Generic
    {
        public void Method()
        {

        }

        public void OtherMethod()
        {

        }

        public List<T> CreateList<T>(T[] initialValues)
        {
            var list = new List<T>();

            foreach (var t in initialValues)
            {
                list.Add(t);
            }

            return list;
        }
    }
}
