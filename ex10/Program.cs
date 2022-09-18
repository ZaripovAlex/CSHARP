Console.Clear;
int[] array = new int[10];
void FillArray(int[] col)
{
    int n= col.Length;
    int i=0;
    while (i<n)
    {
        col[i]=new Random().Next(1,10);
        i++;
    }
}
void PrintArray(int[] arr)
{
    int n = arr.Length;
    int i =0;
    while (i<n)
    {
        Console.WriteLine(arr[i]);
    }
}
int[] IndexOf(int[] arr, int f)
{
    int n=arr.Length;
    int i=0;
    while(i<n)
    {
        if(arr[i]==f)
        {
            int pos = i;
            break;
        }
        
