void mod(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    System.Console.WriteLine($"Сумма четных чисел : {sum}");
}
int n = Convert.ToInt32(Console.ReadLine());
mod(n);
