// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1000 || number < 100)
{
    Console.WriteLine("Не трехзначное число!!!");
    return;
}
int GetSecond(int number)
{
    while (number >= 1000) number /= 100;
    int d = number % 10;
    return d;
}
Console.WriteLine(GetSecond(number));

