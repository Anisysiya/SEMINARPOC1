// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
    }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("[ ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 4} ");
    }
    Console.WriteLine("]    ");
    }
}

int SumElemDiagonal(int[,] matrix)
{
    int sumElem = 0;
    // int size = matrix.GetLength(0);
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1);

    // for (int i = 0; i < size; i++)
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
             sumElem += matrix[i, i];
    } 
    return sumElem;
}  


int[,] array2d = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(array2d);

Console.WriteLine();

int sumElem = SumElemDiagonal(array2d);
Console.WriteLine($"Сумма элементов главной диагонали = {sumElem}");


