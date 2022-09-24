//7. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int x = new Random().Next(-10, 10);
Console.WriteLine(x);
int y = new Random().Next(-10, 10);
Console.WriteLine(y);
if ((x==0)&(y==0)) Console.WriteLine("Точка 0!");
if ((x>0)&(y>0)) Console.WriteLine("Четверть 1");
if ((x>0)&(y<0)) Console.WriteLine("Четверть 2");
if ((x<0)&(y>0)) Console.WriteLine("Четверть 4");
if ((x<0)&(y<0)) Console.WriteLine("Четверть 3");
if ((x==0)&(y!=0)) Console.WriteLine("Ось Y");
if ((x!=0)&(y==0)) Console.WriteLine("Ось X");