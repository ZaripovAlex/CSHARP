Console.Write("Введите число ");
int a = Int32.Parse(Console.ReadLine());
if (a%2==0)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" нечетное");
}