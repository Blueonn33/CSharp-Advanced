namespace _06_songs_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new(songs);
            string command = "";

            while (queue.Count > 0)
            {
                command = Console.ReadLine();
                string action = command.Substring(0, 4).Trim();
                string song = command.Substring(action.Length).Trim();

                switch (action)
                {
                    case "Add":
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                    case "Play":

                        if (queue.Count > 0)
                        {
                            queue.Dequeue();
                        }

                        break;

                    case "Show":

                        if (queue.Count > 0)
                        {
                            Console.WriteLine(string.Join(", ", queue));
                        }

                        break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
