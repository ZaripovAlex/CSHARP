// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.    d = √ (х 1 – х 2) 2 + (у1 – у 2) 2

Console.Clear();
Console.Write("Введите число ");
int x1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите число ");
int y1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите число ");
int x2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите число ");
int y2 = Int32.Parse(Console.ReadLine());
double d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine(d);
