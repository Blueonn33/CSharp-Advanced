//var myDelegate = new MyDelegate(PrintHello);

//myDelegate += PrintGoodbye;

//GetDelegate(myDelegate);

//var numberDelegate = new CalculationDelegate(Sum);

//var result1 = numberDelegate(5, 10);
//Console.WriteLine($"Sum: {result1}");

//static void GetDelegate(MyDelegate myDelegate)
//{
//    myDelegate();
//}

//static int Sum(int x, int y)
//{
//    return x + y;
//}

//static int Multiply(int x, int y)
//{
//    return x * y;
//}

//static void PrintHello()
//{
//    Console.WriteLine("Hello from delegate!");
//}

//static void PrintGoodbye()
//{
//    Console.WriteLine("Goodbye from delegate!");
//}

//delegate void MyDelegate();
//delegate int CalculationDelegate(int x, int y);

using System.Threading.Channels;

Action myMethod = () => Console.WriteLine("Hello");

var myPrintNameMethod = () => Console.WriteLine("John Doe");

var myPrintMethod = Print;

myMethod();

static void ActionableMethod(Action action)
{
    action();
}

//static void PrintHello()
//{
//    Console.WriteLine("Hello");
//}

static void Print(string text)
{
    Console.WriteLine(text);
}