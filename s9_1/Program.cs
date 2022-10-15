// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Numbers();

void Numbers (int s=1)
{
    //int s=0;
    if(s<=N)
    {
        Console.Write($" {s} ");
        Numbers(s+1);
    }   
}