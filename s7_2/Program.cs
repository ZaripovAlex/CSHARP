// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void ZapArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
      {
        array[i,j]= i+j;
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
