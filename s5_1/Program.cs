//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-9, 10);
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
        Console.WriteLine(array[position]);
        position++;
    }
}
int[] arr = new int[12];
FillArray(arr);
int sum1=0;
int sum2=0;
for (int i=0; i<12;i++)
{
    if (arr[i]>0)
    {
        sum1=sum1+arr[i];
    }
    else
    {
        sum2 = sum2+arr[i];
    }
}
PrintArray(arr);
Console.WriteLine($"Сумма положительных чисел: {sum1}");
Console.WriteLine($"Сумма положительных чисел: {sum2}");