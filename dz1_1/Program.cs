Console.Write("Введите первое число ");
int ch1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int ch2 = Int32.Parse(Console.ReadLine());
if(ch1>ch2)
{
    Console.Write("Больше число ");
    Console.WriteLine(ch1);
    Console.Write("Меньшее число ");
    Console.WriteLine(ch2);
    }
else
{
    Console.Write("Больше число ");
    Console.WriteLine(ch2);
    Console.Write("Меньшее число ");
    Console.WriteLine(ch1);
}