void mod(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
       sum*=i;
    }
    System.Console.WriteLine($"Факториал : {sum}");
}
int n = Convert.ToInt32(Console.ReadLine());
mod(n);
