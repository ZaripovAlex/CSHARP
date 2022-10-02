// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.


Console.Clear();
Console.Write("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третее число ");
int n3 = Convert.ToInt32(Console.ReadLine());
if((n1+n2>n3)&(n2+n3>n1)&(n1+n3>n2))
{
    Console.WriteLine("Такой треугольник возможен!");
}
else
{
    Console.WriteLine("Такой треугольник невозможен!");
}