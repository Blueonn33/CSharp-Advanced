using var writer = new StreamWriter("PlaygroundWrite.txt");
using var reader = new StreamReader("Playground.txt");

int counter = 1;

while (true)
{
    var line = reader.ReadLine();

    if (line == null)
    {
        break;
    }

    writer.WriteLine($"{counter}. {line}");
    counter++;
}

Console.WriteLine("Done");

// .  -> текуща директория
// .. -> родителска директория