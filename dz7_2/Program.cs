// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void FindMatrix(int[,] ar)
{
    Console.Write("Введите номер строки ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца ");
    int m = Convert.ToInt32(Console.ReadLine());
    if(n>=ar.GetLength(0)|| n<0||m>=ar.GetLength(1)||m<0) 
    {
        Console.WriteLine($"Элемента с индексами ({n},{m}) не существует");
    }
    else
    {
        Console.WriteLine($"Элемент с индексами ({n},{m}) : {ar[n,m]}");
    }
}

Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов мвссива ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[n, m];
FillMatrix(ar);
PrintMatrix(ar);
FindMatrix(ar);