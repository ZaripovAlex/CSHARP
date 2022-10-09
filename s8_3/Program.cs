// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void MatrixToArray(int[,] array, int[]array1)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[k] = array[i,j];
            k++;
        }
    }
}
void Slovar(int[] array1)
{
    for (int i = 0; i < 10; i++)
    {
        int count = 0;
        for (int j = 0; j < array1.Length; j++)
        {
            if (array1[j] == i)
            count++;
        }
        Console.WriteLine($"{i} встречается {count} раз");
    }
}
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write("{0,-3}", array[i]);
    Console.WriteLine();
}


Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m, n];
int[] ar1 = new int[m * n];
FillMatrix(ar);
PrintMatrix(ar);
MatrixToArray(ar,ar1);
PrintArray(ar1);
Slovar(ar1);


