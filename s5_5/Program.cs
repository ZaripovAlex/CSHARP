// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] rez= new int [n];
FillArray(ar);
PrintArray(ar);
for(int i =0; i<n; i++) 
{
rez[i]=ar[i]*ar[n-i-1];
}
PrintArray(rez);