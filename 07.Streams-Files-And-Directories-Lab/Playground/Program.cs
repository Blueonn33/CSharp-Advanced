using System.Runtime.InteropServices.JavaScript;
using System.Text;

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


var memory = new MemoryStream();

var text = "Martin Marinov";
var textBytes = Encoding.UTF8.GetBytes(text);

memory.Write(textBytes, 0, textBytes.Length);

memory.Flush();

var result = memory.ToArray();

Console.WriteLine(Encoding.UTF8.GetString(result, 0, result.Length));

