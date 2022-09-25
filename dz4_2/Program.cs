// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число ");
int n1 = Int32.Parse(Console.ReadLine());
int c = Convert.ToInt32(Math.Floor(Math.Log10(n1) + 1));
int[] arr = new int[c]; //Массив ради массива
int n=n1; // сохранение числа для вывода
int rez=0;
for(int i=0; i<c; i++)
{
    arr[i]=n%10;
    n=n/10;
    //Console.WriteLine(arr[i]); 
}
for(int i=0; i<c; i++)
{
   rez= rez+arr[i]; 
}
Console.Write($"Сумма чисел числа {n1} ---> {rez}");