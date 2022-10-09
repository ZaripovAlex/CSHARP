// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ZamenaArrey(int[,]array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
    }
}

void FillArrey(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArrey(int[,]array)
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



Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m,n];
FillArrey(ar);
PrintArrey(ar);
ZamenaArrey(ar);
PrintArrey(ar);

