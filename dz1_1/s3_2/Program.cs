//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.Write("Введите число ");
int a = Int32.Parse(Console.ReadLine());
if (a==1) Console.WriteLine("X>0 Y>0");
if (a==2) Console.WriteLine("X<0 Y>0");
if (a==3) Console.WriteLine("X<0 Y<0");
if (a==4) Console.WriteLine("X>0 Y<0");


