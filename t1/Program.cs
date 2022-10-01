// Программа генерирует массив. Если ввести положительное число, то сдвиг вправо на число раз. Если отприцательное - влево.

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 11);
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]},");
        position++;
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите количество элементов мвссива ");
int n = Convert.ToInt32(Console.ReadLine());
//int[] ar = {0,1,2,3,4,5,6,7,8,9,10};
int[] ar=new int[n];
Console.Write("Введите сдвиг ");
int s = Convert.ToInt32(Console.ReadLine());
FillArray(ar);
PrintArray(ar);
int temp=0;
if (s>0)
{
    for(int i=0; i<s; i++)
    {
        temp= ar[n-1];
        //Console.WriteLine($"temp = {temp}");
        for(int j=n-1; j>=1; j--)
        {
            ar[j]=ar[j-1];
            //Console.Write($"{j}, ");
        } 
        ar[0]=temp;
        //Console.WriteLine($"ar0 = {ar[0]}");
    }
}
else if(s<0)
{
    for(int i=0; i<-s; i++)
    {
        temp= ar[0];
        //Console.WriteLine($"temp = {temp}");
        for(int j=0; j<n-1; j++)
        {
            ar[j]=ar[j+1];
            //Console.Write($"{j}, ");
        } 
        ar[n-1]=temp;
        //Console.WriteLine($"ar0 = {ar[0]}");
    }
}
PrintArray(ar);