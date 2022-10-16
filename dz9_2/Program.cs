// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int NatNums1(int n, int m)
{
    if (n <= m)
        return n  + NatNums1(n + 1, m);
    else
        return 0;
}
int NatNums2(int n, int m)
{
    if (m <= n)
        return m  + NatNums2(n, m + 1);
    else
        return 0;
}
Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());
int s = 0;
if (n < m)
    s = NatNums1(n, m);
else
    s = NatNums2(n, m);
Console.WriteLine(s);
