// // Задача 58: Задайте две матрицы. Напишите программу,
// //  которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

int[,] matrixA = Create2DMatrix(4, 5, 0, 10); // Создаем матрицу
Console.WriteLine("\nМатрица A:");
Print2DMatrix(matrixA);
int[,] matrixB = Create2DMatrix(5, 4, 0, 10); // Создаем матрицу
Console.WriteLine("\nМатрица B:");
Print2DMatrix(matrixB);

// Функция заполнения матриц случайными числами от min до max
int[,] Create2DMatrix(int column, int row, int min, int max)
{
    int[,] matrix = new int[column, row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}
// Функция вывода двумерных матриц
void Print2DMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
}
//Функция произведения двух матриц
int[,]? GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int columnA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0);
    int columnB = matrixB.GetLength(1);

    int[,] matrixResult = new int[rowA, columnB];

    if (columnA != rowB)
    {
        return null;
    }

    for (int mA = 0; mA < rowA; mA++)
    {
        for (int nB = 0; nB < columnB; nB++)
        {
            int sum = 0;
            for (int mB = 0; mB < rowB; mB++)
            {
                sum += matrixA[mA, mB] * matrixB[mB, nB];
            }
            matrixResult[mA, nB] = sum;
        }
    }
    return matrixResult;
}


Console.WriteLine("\nПроизведения двух матриц А на матрицу В:");
Print2DMatrix(GetMultiplicationMatrix(matrixA, matrixB));