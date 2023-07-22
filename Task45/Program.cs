// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int min = -10;
int max = 10;
int size = 5;
int[] array = CreateArrayRndInt(size, min, max);

Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Новый массив: ");
int[] array2 = CopyArray(array);

array2[0] = 1000;

PrintArray(array2);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1) break;
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}