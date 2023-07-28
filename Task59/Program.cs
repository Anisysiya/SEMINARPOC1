// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateMatrixyRndInt(int rows, int colums, int min, int max) // Для двумерного массива в сигнатуре указываются строки rows и столбцы colums.

{
    int[,] matrix = new int[rows, colums];              // Создали двумерный массив заполненный нулями. rows=3, colums=4.

    Random rnd = new Random();                          //Создали объект Random.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);       // +1 потому что в методе Next интервал не включен

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] FindPosOfMin(int[,] matrix)
{
    int minRow = 0, minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { minRow, minColumn };
}

int[,] RemoveCrossMinElement(int[,] matrix, int row, int column)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int m = 0, n = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (n == column) n++;
            result[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return result;
}

int[,] array2d = CreateMatrixyRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] pos = FindPosOfMin(array2d);
int[,] res = RemoveCrossMinElement(array2d, pos[0], pos[1]);
PrintMatrix(res);

