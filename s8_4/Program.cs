// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


Console.Clear();
Console.Write("Введите количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ar = new int[m, n];
int mini=0;
int minj=0;
FillMatrix(ar);
PrintMatrix(ar);
SearchMinPosition(ar);
int[,] ar1 = DeleteMin(ar);
PrintMatrix(ar1);

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintMatrix(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-5}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SearchMinPosition(int[,] array)
{
    int min=array[0,0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<min)
            {
                min=array[i,j];
                mini=i;
                minj=j;
            }
        }        
    }
    Console.WriteLine($"min = {min}, mini = {mini}, minj= {minj}");
}
int[,] DeleteMin(int[,]array)
{
    int x=0;
    int y=0;
    int[,]rez=new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0);i++)
    {
        y=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==mini || j==minj)
            {
                                
            }
            else
            {
                rez[x,y]=array[i,j];
            }
        //    Console.WriteLine($"y = {y}");
            y++;
            
        }        
      //  Console.WriteLine($"x = {x}");
        x++;
        
    }
    return rez;
}
