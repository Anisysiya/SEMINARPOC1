// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("Ведите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
