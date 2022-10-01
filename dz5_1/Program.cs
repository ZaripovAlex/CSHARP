// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве..
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
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
int z=0;
FillArray(ar);
PrintArray(ar);
for(int i=0; i<n; i++)
{
    if(ar[i]%2==0)
    {
        z=z+1;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: - {z}");