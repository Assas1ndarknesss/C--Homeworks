int[] arr;
int n = Convert.ToInt32(Console.ReadLine());
arr = new int[n];
int max = -9999999;
int max_in=0;

for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        max_in = i;
    }
}
        Console.WriteLine(max_in);
