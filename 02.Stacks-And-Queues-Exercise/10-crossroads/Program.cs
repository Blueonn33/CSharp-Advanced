namespace _10_crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            int passed = 0;
            int green = 0;

            Queue<string> cars = new();

            string command = "";

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    green = greenLightDuration; 
                }
                else
                { 
                    cars.Enqueue(command);

                    if (green >= command.Length)
                    {
                        cars.Dequeue();
                        passed++;
                        green -= command.Length;
                    }
                    else
                    {
                        if (command.Length - green > 0)
                        {
                            command = command.Substring(0, green);

                        }
                    }
                }
            }
        }
    }
}
