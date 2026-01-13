int n = int.Parse(Console.ReadLine());

char[,] board = new char[n, n];

for (int row = 0; row < n; row++)
{
    var currentRow = Console.ReadLine().ToCharArray();

    for (int col = 0; col < n; col++)
    {
        if (currentRow[col] == 'K')
        {
            board[row, col] = 'K';
        }
        else
        {
            board[row, col] = '0';
        }
    }
}

var removedKnights = 0;

while (true)
{
    int maxAttacks = 0;
    int maxAttackRow = -1;
    int maxAttackCol = -1;

    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            if (board[row, col] == 'K')
            {
                int attacks = CalculateAttacks(board, row, col);
                if (attacks > maxAttacks)
                {
                    maxAttacks = attacks;
                    maxAttackRow = row;
                    maxAttackCol = col;
                }
            }
        }
    }

    if (maxAttacks == 0)
    {
        break;
    }

    board[maxAttackRow, maxAttackCol] = '0';
    removedKnights++;
}

Console.WriteLine(removedKnights);

static int CalculateAttacks(char[,] board, int row, int col)
{
    int totalAttacks = 0;

    if (ValidCoordinates(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
    {   
        totalAttacks++;
    }   
        
    if (ValidCoordinates(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
    {
        totalAttacks++;
    }

    if (ValidCoordinates(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
    {
        totalAttacks++;
    }

    return totalAttacks;
}

static bool ValidCoordinates(char[,] board, int row, int col)
{
    return row >= 0 && row < board.GetLength(0)
        && col >= 0 && col < board.GetLength(1);
}