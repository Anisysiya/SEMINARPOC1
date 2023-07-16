// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120




int GetCountDitgitNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

long GetMultiplicationNumber(int number)
{
    if (number == 0)
    {
        Console.WriteLine("Нулик");
        return 0;
    }
    long result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}