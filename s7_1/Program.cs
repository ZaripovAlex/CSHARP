// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void ZapArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
      {
        array[i,j]= new Random().Next(0,100);
      }
    }
}
void PrintArray(int[,] ar)
{
    for(int i=0; i<ar.GetLength(0); i++)
    {
      for(int j=0; j<ar.GetLength(1); j++)
      {
       Console.Write($"{ar[i,j]},");
      }
       Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов мвссива ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int [n,m];
ZapArray(ar);
PrintArray(ar);
