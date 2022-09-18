//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите число ");
int num = Int32.Parse(Console.ReadLine());
if ((num>99) & (num<1000))
{
    int num1=num/10;
    int num2=num1%10;
    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine("Неверное число");
}