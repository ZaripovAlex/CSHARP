// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,]array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)     
    {
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            Console.Write("{0,-5}",array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ZamenaArray(int[,]array, int[,] array1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[j,i] = array[i,j];
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m,n];
int[,] ar1 = new int[m,n];
if (m != n)
{
    Console.Write($"Замена невозможна");
}
else
{
FillArray(ar);
PrintArray(ar);
ZamenaArray(ar,ar1);
PrintArray(ar1);
}