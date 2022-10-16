// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();
string NatNums1(int n, int m)
{
    if (n <= m)
        return $"{n} " + NatNums1(n + 1, m);
    else
        return String.Empty;
}
string NatNums2(int n, int m)
{
    if (m <= n)
        return $"{m} " + NatNums2(n, m + 1);
    else
        return String.Empty;
}
Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());
string s = String.Empty;
if (n < m)
    s = NatNums1(n, m);
else
    s = NatNums2(n, m);
Console.WriteLine(s);
