
namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxList<string> list = new();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                Box<string> box = new(word);

                list.Data.Add(box);
            }

            //int[] indexes = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //list.Swap(indexes[0], indexes[1]);

            //foreach (var box in list.Data)
            //{
            //    Console.WriteLine(box);
            //}

            Console.WriteLine(list.GetBiggerBoxes(new Box<string>(Console.ReadLine())));
        }
    }
}
