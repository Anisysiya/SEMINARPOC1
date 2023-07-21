// 1.Задайте массив заполненный 
//2.случайными положительными трёхзначными числами.
// 3.Напишите программу,которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRndNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        count++;
}        

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRndNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}
