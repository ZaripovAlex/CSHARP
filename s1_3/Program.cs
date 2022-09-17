// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите число ");
int N = Int32.Parse(Console.ReadLine());
int i = N* -1;
if (N<i)
{
    i*=-1;
    N*=-1;
}
while(i<N)
{
    Console.WriteLine(i);
    i++;
}
