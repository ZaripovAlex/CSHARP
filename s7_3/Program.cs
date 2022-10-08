// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void ZapArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
      {
        array[i,j]= new Random().Next(0,10);
      }
    }
}
void Zamena(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
      {
        if((i%2==0) && (j%2==0))
        {
            array[i,j]=array[i,j]*array[i,j];
        }
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
Zamena(ar);
PrintArray(ar);