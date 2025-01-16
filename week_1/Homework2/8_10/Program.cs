void mod(int n)
{
    int cnt = 0;
    for (int i=2; i <=n; i++)
    {
        if (n % i == 0)
        {
            cnt++;
        }

    }
    System.Console.WriteLine(cnt);
    if (cnt < 2)
    {

        System.Console.WriteLine($"Простое число: Да");
    }
    else{

        System.Console.WriteLine($"Простое число:  Нет");
    }

}
int n = Convert.ToInt32(Console.ReadLine());
mod(n);
