// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите M");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int k = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(j,k));

int Akkerman(int n, int m)
{
    if (n == 0)
    {
       return m + 1; 
    } else
    {
        if ((n != 0) && (m == 0))
        {
            return Akkerman(n - 1, 1);
        }else
        {
           return Akkerman(n - 1, Akkerman(n, m - 1)); 
        }
    }
}
Console.WriteLine("Программа, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Вычисление функции Аккермана");