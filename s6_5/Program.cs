//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 11);
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]},");
        position++;
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] ar = new int [n];
int[] arr = new int[n];
FillArray(ar);
PrintArray(ar);
for (int i = 0; i < n; i++)
{
    arr[i] = ar[i];
}
PrintArray(arr);
