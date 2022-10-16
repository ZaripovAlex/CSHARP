//ПРограмма просит ввести число и выдает сумму чисел


Console.Clear();
int SumNum(int n)
{
    int s = 0;
    if (n / 10 > 0)
        return s + n % 10 + SumNum(n / 10);
    else
        return n % 10;
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));

