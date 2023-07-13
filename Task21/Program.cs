// Напишите программу, которая принимает на вход
//  координаты двух точек и находит
//   расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(
    Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)),
    2
);
Console.Write("Расстояние между A и B: " + distance);

double GetDistance(int a1, int a2, int b1, int b2)
{
    double firstCatet = b1 - a1;
    double secondCatet = b2 - a2;
    double distance = Math.Sqrt(firstCatet * firstCatet + secondCatet * secondCatet);
    return distance;

}