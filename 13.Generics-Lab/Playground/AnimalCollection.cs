using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class AnimalCollection<T> where T : Animal, new()
    {
        private List<T> list;

        public AnimalCollection()
        {
            this.list = new List<T>();
            var animal = new T();
        }

        public void SayType()
        {
            foreach (var item in this.list)
            {
                item.SayHello();
            }
        }
    }
}
