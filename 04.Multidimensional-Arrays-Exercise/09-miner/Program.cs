int n = int.Parse(Console.ReadLine());

string[] commandInput = Console.ReadLine().Split();
Queue<string> commands = new(commandInput);

char[,] matrix = new char[n, n];
int coals = 0;
int collectedCoals = 0;
int minerRow = 0;
int minerCol = 0;
bool isExit = false;

for (int row = 0; row < n; row++)
{
    char[] rowInput = Console.ReadLine()
        .Split()
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < rowInput.Length; col++)
    {
        if (rowInput[col] == ' ')
        {
            continue;
        }

        matrix[row, col] = rowInput[col];

        if (matrix[row, col] == 'c')
        {
            coals++;
        }

        if (matrix[row, col] == 's')
        {
            minerRow = row;
            minerCol = col;
        }
    }
}

while (commands.Count > 0)
{
    string direction = commands.Dequeue();

    switch (direction)
    {
        case "up":
            if (minerRow - 1 >= 0)
            {
                minerRow--;
            }
            break;
        case "down":
            if (minerRow + 1 < n)
            {
                minerRow++;
            }
            break;
        case "left":
            if (minerCol - 1 >= 0)
            {
                minerCol--;
            }
            break;
        case "right":
            if (minerCol + 1 < n)
            {
                minerCol++;
            }
            break;
    }

    if (matrix[minerRow, minerCol] == 'c')
    {
        collectedCoals++;
        coals--;
        matrix[minerRow, minerCol] = '*';

        if (coals == 0)
        {
            break;
        }
    }
    else if (matrix[minerRow, minerCol] == 'e')
    {
        isExit = true;
        break;
    }
}

if (coals == 0)
{
    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
}
else if (isExit)
{
    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
}
else
{
    Console.WriteLine($"{coals} coals left. ({minerRow}, {minerCol})");
}