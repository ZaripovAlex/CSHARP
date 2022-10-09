// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
int[] SunElem(int[,] array)
{
    int[] rez = new int[array.GetLength(1)];
    int sum=0;
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            sum=sum+array[i,j];
        }
        rez[i]=sum;
        sum=0;
    }
    return rez;
}
void PrintArray(int[] array)
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
int SearchMinPosition(int[] array)
{
    int min=array[0];
    int mini=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
          {
             min=array[i];
             mini=i;            
            }
    }   
    return mini;     
    //Console.WriteLine($"min = {min}, mini = {mini}");
}
Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m, n];
FillMatrix(ar);
PrintMatrix(ar);
int[] ar1 =SunElem(ar);
PrintArray(ar1);
int min = SearchMinPosition(ar1);
Console.WriteLine($"Минимальная сумма элементов в {min} строке");
