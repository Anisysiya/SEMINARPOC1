// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void ReplaceFirstLastRows(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;
    }
}

int[,] array2d = CreateMatrixyRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceFirstLastRows(array2d);
PrintMatrix(array2d);