// Задача 57: Составить частотный словарь элементов
//              двумерного массива. Частотный словарь содержит
//              информацию о том, сколько раз встречается элемент
//              входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void FrequencyDictionary(int[] arr)
{
    int currentNum = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentNum) count++;
        else
        {
            Console.WriteLine($"{currentNum} содержится {count} раз");
            count = 1;
            currentNum = arr[i];
        }
    }
    Console.WriteLine($"{currentNum} содержится {count} раз");
}

int[,] array2d = CreateMatrixyRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] arrMain = MatrixToArray(array2d);
Array.Sort(arrMain);
PrintArray(arrMain);

FrequencyDictionary(arrMain);