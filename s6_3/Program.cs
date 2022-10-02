// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Введите число ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n=n1;
string s = "";
string x = "";
while (n > 0)
{
    x = Convert.ToString(n % 2);
    s = x + s;
    n/= 2;
}
Console.WriteLine($"{n1}(10)-->{s}(2)");



// Console.Clear();
// Console.WriteLine("Введите десятичное число");
// int a = Convert.ToInt32(Console.ReadLine());
// int x = a % 2;
// a /= 2;
// int i = 10;
// while (a > 0)
// {
//     x = x + (a % 2) * i;
//     a /= 2;
//     i *= 10;
// }
// Console.WriteLine(x);


// Console.Clear();
// int num = Convert.ToInt32(Console.ReadLine());
// string s = "";
// string x = "";
// while (num > 0)
// {
//     x = Convert.ToString(num % 2);
//     s = x + s;
//     num /= 2;
// }
// Console.WriteLine(s)



