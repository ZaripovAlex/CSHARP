// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// 

Console.Clear();
int[] p1 = new int[3];
int[] p2 = new int[3];
void ZapArray(int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(1, 10);
        i++;
    }
}
ZapArray(p1);
ZapArray(p2);
double d=Math.Sqrt(Math.Pow(p1[0]-p2[0],2)+Math.Pow(p1[1]-p2[1],2)+Math.Pow(p1[2]-p2[2],2));
Console.WriteLine(d);