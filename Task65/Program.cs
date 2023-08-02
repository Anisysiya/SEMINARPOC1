// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NaturalNumbersRange(int m, int n)
{
    if (m > n)
    {
        Console.Write($" {m}");
        NaturalNumbersRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($" {m}");
        NaturalNumbersRange(m + 1, n);
    }
    else Console.Write($" {m}");
}

Console.WriteLine("Input number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Incorrect numbers");
    return;
}
NaturalNumbersRange(number1, number2);