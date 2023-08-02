// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] twoDimArray = new double[3, 4];

Random rnd = new Random();

void PrintArray(double[,] matr)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matr[i, j] = rnd.Next(-100,100) / 10.0;
        }
    }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);