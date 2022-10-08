﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double[,] array)
{
    Random rnd = new Random();
    for(int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
      {
        array[i,j]=Math.Round(2*rnd.NextDouble(), 2);
      }
    }
}
void PrintMatrix(double[,] ar)
{
    for(int i=0; i<ar.GetLength(0); i++)
    {
      for(int j=0; j<ar.GetLength(1); j++)
      {
       Console.Write($"{ar[i,j]}, ");
      }
       Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] ar = new double [n,m];
FillMatrix(ar);
PrintMatrix(ar);
