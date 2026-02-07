namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public void Add(T element)
        {
            this.items.Add(element);
        }

        public T Remove()
        {
            var lastIndex = this.items.Count - 1;
            var lastItem = this.items[lastIndex];

            this.items.RemoveAt(lastIndex);

            return lastItem;
        }
    }
}