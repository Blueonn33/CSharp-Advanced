using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
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

// Работа с паметови потокове

var memory = new MemoryStream();

var text = "Martin Marinov";
var textBytes = Encoding.UTF8.GetBytes(text);

memory.Write(textBytes, 0, textBytes.Length);

memory.Flush();

var result = memory.ToArray();

Console.WriteLine(Encoding.UTF8.GetString(result, 0, result.Length));

// Работа с файлов потокове

using var fileStreamCreate = new FileStream("file.txt", FileMode.Create);

var buffer = Encoding.UTF8.GetBytes("Hello File Stream");

fileStreamCreate.Write(buffer, 0, buffer.Length);
fileStreamCreate.Close();

using var fileStreamOpen = new FileStream("file.txt", FileMode.Open);

var bufferOpen = new byte[fileStreamOpen.Length];

fileStreamOpen.Read(bufferOpen, 0, bufferOpen.Length);

var textResult = Encoding.UTF8.GetString(bufferOpen);
Console.WriteLine(textResult);