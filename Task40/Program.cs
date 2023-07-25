// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первую сторону треугольника: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool isTriangle = IsTriangleExists(firstSide, secondSide, thirdSide);
Console.WriteLine(isTriangle ? "Треугольник существует": "Треугольник не существует");

bool IsTriangleExists(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

