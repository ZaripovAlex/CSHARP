// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Введите число, которое будем возводить в степень ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите степень, в которую будем возводить ");
int b = Math.Abs(Int32.Parse(Console.ReadLine()));
int rez=1;
for(int i=1; i<=b; i++)
{
     rez=rez*a;
    // Console.WriteLine(rez);
}
Console.WriteLine($"Если число {a} возвести в степень {b}, то получится {rez}");
