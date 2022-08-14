// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double LengthofSegment3D (int x1coord, int y1coord, int z1coord, int x2coord, int y2coord, int z2coord)
{
    double res = Math.Sqrt((x1coord-x2coord)*(x1coord-x2coord) + (y1coord-y2coord)*(y1coord-y2coord) + (z1coord-z2coord)*(z1coord-z2coord));
    return res;
}

Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(LengthofSegment3D (x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x1},{y1},{z1}) B ({x2},{y2},{z2}) -> {result}");
