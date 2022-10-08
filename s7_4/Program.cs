// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


void ZapArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j]},");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintRez(int[,] ar)
{
    int s=0;
    int m=ar.GetLength(0);
    int n=ar.GetLength(1);
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1)-1; j++)
        {
            if (i == j)
            {
                Console.Write($"{ar[i, j]} + ");
                s=s+ar[i,j];
            }
        }
    }
    Console.Write($"{ar[m-1,n-1] } = {s}");
   
    Console.WriteLine();

}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов мвссива ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[n, m];
ZapArray(ar);
PrintArray(ar);
PrintRez(ar);
