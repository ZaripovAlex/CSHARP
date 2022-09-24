//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int[] array = new int[5];
Console.Write("Введите пятизначное число ");
int num = Int32.Parse(Console.ReadLine());
if (num<10000||num>99999) Console.Write("Вы ввели какое-то неправильное пятизначное число");
for(int i=0; i<5; i++)
{
    array[i]=num%10;
    num=num/10;
    //Console.WriteLine(array[i]);
}
if(array[1]==array[3]&array[0]==array[4]) Console.Write ("Введенное число является полиандром");
else Console.Write ("Введенное число неявляется полиандром");
