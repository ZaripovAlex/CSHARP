Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 )
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
    
}
else 
{
    int num3 = num1 % num2;
    Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
}
