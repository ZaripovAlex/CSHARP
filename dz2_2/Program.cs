Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1=0;
if (num<100) 
{
   Console.WriteLine("Третьего числа нет");
}
else if ((num>100) && (num<1000))
{
    num1=num%10;
    Console.WriteLine(num1);
}
else
{
   while (num>1000)
    {
        num=num/10;
    }
     Console.WriteLine(num%10);
   
}
    