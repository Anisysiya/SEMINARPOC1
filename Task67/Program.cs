// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumDigit(num);
Console.WriteLine(sum);

int SumDigit(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigit(number / 10); // 453 -> 45 -> 4 | 4%10 + 45%10 + 453%10 + 0 = 12
}
