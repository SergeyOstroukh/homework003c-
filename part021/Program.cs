// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точек A");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точек B");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int numx1, int numy1, int numz1, int numx2, int numy2, int numz2)
{
    double result = Math.Sqrt (((numx1 - numx2)*(numx1 - numx2)) + ((numy1 - numy2)*(numy1 - numy2)) + ((numz1 - numz2)*(numz1 - numz2)));

    return result;
}
double distance = Distance(x1, y1, z1, x2, y2, z2);
distance = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкой А ({x1},{y1},{z1}) и точкой B ({x2},{y2},{z2}) в 3D пространстве = {distance}");