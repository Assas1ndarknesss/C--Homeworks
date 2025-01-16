int num = Convert.ToInt32(Console.ReadLine());
int []add = new int [num];
for (int i = 0; i < num; i++)
{
    add[i]=Convert.ToInt32(Console.ReadLine());
}
int cnt=0;
for (int i = 0; i < num-1; i++)
{
    if (add[i]<add[i+1]){
        cnt++;
    }
}
System.Console.WriteLine(cnt);