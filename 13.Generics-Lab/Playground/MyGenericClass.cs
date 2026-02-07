using System.Threading.Channels;

namespace Playground
{
    public class MyGenericClass<T>
    {
        private T value;

        public MyGenericClass(T value)
        {
            this.value = value;
        }
        public T GetValue()
        {
            return this.value;
        }

        public void PrintValue()
        {
            Console.WriteLine(this.value);
        }
    }

    /// <summary>
    /// List ot maximum 4 elements
    /// </summary>
    public class LimitedList<T>
    {
        private T[] items;
        private int index;

        public LimitedList()
        {
            this.items = new T[4];
            this.index = 0;
        }

        public void Add(T item)
        {
            if (this.index > this.items.Length)
            {
                return;
            }

            this.items[this.index++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= this.items.Length)
            {
                throw new Exception("Index it out of range.");
            }

            return this.items[index];
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> obj = new(17);
            obj.PrintValue();

            LimitedList<int> numbersList = new LimitedList<int>();
            numbersList.Add(17);
            numbersList.Add(33);
            numbersList.Add(43);
            numbersList.Add(432);

            var number = numbersList.Get(3);
            Console.WriteLine(number);

            var classExample = new Generic();

            int[] nums = [3, 4, 5, 4, 332, 5];

            classExample.CreateList(nums);

            var myList = classExample.CreateList([4, 4, 3, 2, 4, 5]);
                
            Console.WriteLine(myList.Count);
        }
    }
}
