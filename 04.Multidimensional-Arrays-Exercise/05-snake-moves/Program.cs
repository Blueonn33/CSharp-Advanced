int[] size = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

string snake = Console.ReadLine();

var snakeQueue = new Queue<char>(snake);

var matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = NextSnakeSymbol(snakeQueue);
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = NextSnakeSymbol(snakeQueue);
        }
    }
}

for (int row = 0; row < rows; row++)
{

    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }

    Console.WriteLine();
}

static char NextSnakeSymbol(Queue<char> snakeQueue)
{
    var symbol = snakeQueue.Dequeue();
    snakeQueue.Enqueue(symbol);
    return symbol;
}