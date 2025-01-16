void mod(int n)
{
    if (n%2==0)
    {
        System.Console.WriteLine($"четное" );
    }
    else 
    {
        System.Console.WriteLine($"нечетное" );

    }
}
int n = Convert.ToInt32(Console.ReadLine());
mod(n);
