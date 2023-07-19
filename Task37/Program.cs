﻿//  Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int min = 1;
int max = 9;

int size = 5;
int[] array = CreateArrayRndInt(size, min, max);

PrintArray(array);

int[] productPair = GetProductPairNumber(array);

PrintArray(productPair);


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
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] GetProductPairNumber(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] product = new int[size];

    for (int i = 0; i < size; i++)
    {
        int prod = arr[i] * arr[arr.Length - i - 1];
        product[i] = prod;
    }
    if (arr.Length % 2 != 0) product[size - 1] = arr[arr.Length / 2];
    return product;
}