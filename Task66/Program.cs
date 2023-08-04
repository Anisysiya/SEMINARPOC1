// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int m = int.Parse(Console.ReadLine());

int result = 0;
Console.WriteLine(Sum(n, m));

int Sum(int n, int m)
{
    if (m <= n)
        return n;
    return m + Sum(n, m - 1);
}
Console.WriteLine("Cумму натуральных элементов в промежутке от M до N");