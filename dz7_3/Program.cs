// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] ar)
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
void PrintArray(double[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]}; ");
        position++;
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов мвссива ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[n, m];
double[] ar1 = new double[m];
double rez = 0;
FillMatrix(ar);
PrintMatrix(ar);

for (int i = 0; i < ar.GetLength(1); i++)
{
    rez = 0;
    for (int j = 0; j < ar.GetLength(0); j++)
    {
        rez = rez + ar[j, i];

    }
  ;
    ar1[i] = rez / n;
}
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(ar1);

