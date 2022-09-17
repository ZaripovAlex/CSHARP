Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result =num2*num2;
if (result==num1)
{
    Console.Write ($"Число {num2} является квадратом числа {num1}"); 
}
else
{
    Console.Write ($"Число {num2} неявляется квадратом числа {num1}"); 
} 