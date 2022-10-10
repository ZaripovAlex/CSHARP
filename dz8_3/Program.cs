// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintMatrix(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-5}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SumMatrix(int[,] array, int[,] array1)
{
    int[,] rez = new int[array.GetLength(0), array1.GetLength(1)];
    if (array.GetLength(0) == array1.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j<array1.GetLength(1);j++)
            {
                for(int k=0; k<array1.GetLength(0);k++)
                {
                   rez[i,j] += array[i,k] * array1[k,j]; 
                }
            }
        }
    }
    return rez;
}

Console.Clear();
Console.Write("Введите количество строк в первом массиве массиве ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в первом массиве ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк во втором массиве ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов во втором массиве ");
int m2 = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[n1, m1];
int[,] ar1 = new int[n2, m2];
FillMatrix(ar);
PrintMatrix(ar);
FillMatrix(ar1);
PrintMatrix(ar1);
int[,] rez =SumMatrix(ar,ar1);
PrintMatrix(rez);