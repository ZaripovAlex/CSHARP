// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void ZapArray(int[] array)
{
    int n= array.Length;
    for(int i=0; i<n; i++)
    {
        Console.Write($"Введите {i} элемент мвссива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
ZapArray(ar);
PrintArray(ar);
int rez=0;
for(int i=0; i<n; i++)
{
    if (ar[i]>0) rez+=1;
}
Console.WriteLine($"Пользователь ввёл {rez} положительных чисел.");