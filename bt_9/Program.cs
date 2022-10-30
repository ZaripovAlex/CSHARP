// Сортировка подсчетом

int[] array = new int[20];
for (int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(-99,100);
}

Console.WriteLine(string.Join(", ",array));
//CountingSort(array);
Console.WriteLine(string.Join(", ",CountingSortExtended(array)));

void CountingSort(int[] inputArray)
{
    int[] couners= new int[10];
    for (int i = 0; i < inputArray.Length; i++) 
    {
        int ourNumber = inputArray[i];
        couners[ourNumber]++;
        // couners[inputArray[i]]++;
    }

    int index=0;
    for(int i=0; i<couners.Length;i++)
    {
        for (int j = 0; j < couners[i]; j++)
        {
            inputArray[index]=i;
            index++;
        }
    }
}
int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();
    int offset = -min;
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max+1+offset];
    int index=0;
    for (int i = 0; i < inputArray.Length; i++) 
    {
        // int ourNumber = inputArray[i];
        // counters[ourNumber]++;
        counters[inputArray[i]+offset]++;
    }
    for(int i=0; i<counters.Length;i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index]=i-offset;
            index++;
        }
    }
    return sortedArray;
}