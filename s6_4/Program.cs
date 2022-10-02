// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
Console.Write("Введите количество символов чисел Фибоначчи ");
int n = Convert.ToInt32(Console.ReadLine());
int[] ar = new int[n];
ar[0] = 0;
ar[1] = 1;
for (int i = 2; i < ar.Length; i++)
{
    ar[i] = ar[i - 1] + ar[i - 2];
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
PrintArray(ar);