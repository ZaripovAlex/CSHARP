
int[] array =new int[10];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    for(int i=0; i < count; i++)
    {
        Console.WriteLine(col[i]);
    }
}
void SortArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    {
        int min = i;
        for(int j=i+1; j<array.Length; j++)
        {
            if (array[j]<array[min])
            {
                min=j;
            }
        }
        int temp = array[i];
        array[i]=array[min];
        array[min]=temp;
    }
}

FillArray(array);
SortArray(array);
PrintArray(array);