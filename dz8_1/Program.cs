// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int maxi = 0;
int maxj = 0;
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m, n];
FillMatrix(ar);
PrintMatrix(ar);
SortArray(ar);
PrintMatrix(ar);


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
void SearchMaxPosition(int[,] array, int s, int z)
{
    int max = array[s, z];
    for (int i = z; i < array.GetLength(1); i++)
    {

        {
            if (array[s, i] > max)
            {
                max = array[s, i];
                maxi = i;
                maxj=s;
            }
        }
        
    }
    Console.WriteLine($"max = {max}, maxi = {maxi}, minj= {s}");
    //return max;
}

void SortArray(int[,]array)
{
    for(int i=0; i<array.GetLength(1); i++)
    {
        for(int j=0; j<array.GetLength(0); j++)
        {
            int max = j;
            for(int k=j+1; k<array.GetLength(1); k++)
            {
            if (array[i,k]>array[i,max])
            {
                max=k;
            }
            }
        int temp = array[i,j];
        array[i,j]=array[i,max];
        array[i,max]=temp;
        }
    }
}



