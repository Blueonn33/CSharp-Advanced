
namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                Box<int> box = new(int.Parse(word));

                Console.WriteLine(box);
            }
        }
    }
}
