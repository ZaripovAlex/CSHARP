int[] array= {1,2,3,10,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21};
int n=array.Length;
int f =10;
int i=0;
while(i<n)
{
    if(array[i]==f)
    {
         Console.WriteLine(i);
         break;
    }
    i++;
}