// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 101);
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
FillArray(ar);
PrintArray(ar);
int min=ar[0];
int max=ar[0];
for(int i=0; i<n; i++)
{
    if(ar[i]>max) max = ar[i];
    if(ar[i]<min) min = ar[i];
}
// Console.WriteLine(min);
// Console.WriteLine(max);
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементоv массива: -  {max-min}");