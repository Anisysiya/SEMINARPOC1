// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string fivenumber = Console.ReadLine();
int dlina = fivenumber.Length;

if (dlina == 5)
{
    if (fivenumber[0] == fivenumber[4] && fivenumber[1] == fivenumber[3])
    {
        Console.WriteLine($"{fivenumber} - число-палиндром");
    }
    else
    {
        Console.WriteLine($"{fivenumber} - не зеркально, это не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {fivenumber} - не является пятизначным числом по условию");
}