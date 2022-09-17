//Найти большее из 9ти чисел
Console.Clear();
Console.Write("Введите 1 число ");
int n1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 2 число ");
int n2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 3 число ");
int n3 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 4 число ");
int n4 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 5 число ");
int n5 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 6 число ");
int n6 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 7 число ");
int n7 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 8 число ");
int n8 = Int32.Parse(Console.ReadLine());
Console.Write("Введите 9 число ");
int n9 = Int32.Parse(Console.ReadLine());
int Max(int ar1, int ar2, int ar3)
{
    int rez = ar1;
    if(ar2>rez) rez=ar2;
    if(ar3>rez) rez=ar3;
    return rez;
}
int m1 = Max(n1,n2,n3);
int m2 = Max(n4,n5,n6);
int m3 = Max(n7,n8,n9);
int max = Max(m1,m2,m3);
Console.WriteLine(max);