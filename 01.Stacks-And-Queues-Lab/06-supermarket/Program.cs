namespace _06_supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            Queue<string> customers = new();

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(command);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
