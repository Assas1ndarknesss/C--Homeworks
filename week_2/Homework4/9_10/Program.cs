int a=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[a];
void add(int a)
{
    int sum=0;
    int cnt=0;
    for (int i = 0; i <a; i++)
    {
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i <a; i++)
    {
        cnt++;
       sum+=arr[i];
    }
    System.Console.WriteLine($"Среднее значение : {sum/cnt} (пример)");
}
add(a);
