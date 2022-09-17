// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.Clear();
Console.Write("Введите число ");
int N = Int32.Parse(Console.ReadLine());
if ((N>99)&(N<1000))
{
    Console.WriteLine(N%10);
} 
else
{
    Console.WriteLine("Неправильное число");
}

