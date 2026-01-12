namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3]
            {
                {17, 33, 22},
                {45, 12, 9}
            };

            string[,,] cube = new string[2, 2, 2];

            matrix[1, 1] = 17;

            //Console.WriteLine(matrix[1, 1]);

            int[,] matrix2 =
            {
                {1,2},
                {3,4},
                {5,6}
            };

            var arr = new[] { 1, 2, 3, 4 };

            //Console.WriteLine(matrix.GetLength(0)); // number of rows
            //Console.WriteLine(matrix.GetLength(1)); // number of columns

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            string[,] textMatrix = new string[2, 5];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    textMatrix[row, col] = $"[{row},{col}]";
                }
            }

            //PrintMatrix(textMatrix);

            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];

            jaggedArray[0][1] = 17;

            Console.WriteLine(jaggedArray[0][1]);
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ReadMatrix()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"Enter [{row},{col}]: ");

                    int value = int.Parse(Console.ReadLine());
                    matrix[row, col] = value;
                }
            }

            return matrix;
        }
    }
}
