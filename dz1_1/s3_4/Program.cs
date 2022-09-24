// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число ");
int n = Int32.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
  Console.WriteLine($"{Math.Pow(i,2)} ");  