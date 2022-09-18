//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int num = new Random().Next(100, 999);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num / 100;

Console.WriteLine();
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num2 * 10 + num1);