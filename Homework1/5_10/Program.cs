int[] arr;
int n = Convert.ToInt32(Console.ReadLine());
arr = new int[n];
int min=9999999;
int min_in=0;
for (int i = 0; i <n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i <n; i++)
{
    if (arr[i]<min)
    {
       min=arr[i];
       min_in=i;
    }
   
}
Console.Write(min_in);
