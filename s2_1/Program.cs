Console.Clear();
Console.Write("Ввдите число");
int num =new Random().Next(10,99);
int num1= num%10;
int num2=num/10;
if (num1>num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
Console.WriteLine(num);
