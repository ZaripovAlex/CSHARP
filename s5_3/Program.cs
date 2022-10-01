// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-10, 11);
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
}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число ");
int num = Convert.ToInt32(Console.ReadLine());
int[] ar = new int [N];
FillArray(ar);
PrintArray(ar);
Console.WriteLine();
int flag=0;
for(int i=0; i<N; i++)
{
    if(ar[i]==num)
    {
        Console.WriteLine($"Число {num} есть ");
        flag=1;
        break;
    }
        
}
 if(flag==0)Console.WriteLine($"Числа {num} нет ");
