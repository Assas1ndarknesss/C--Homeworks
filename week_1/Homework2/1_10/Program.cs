void mod (double n)
{
    if (n < 50)
    {
        System.Console.WriteLine(n-((n * 5) / 100) );
    }
    else if (n == 50 && n < 100)
    {
        System.Console.WriteLine(n-((n * 10) / 100) );
    }
    else 
    {
        System.Console.WriteLine(n-((n * 15) / 100));
    }
}
double n = Convert.ToInt32(Console.ReadLine());
mod(n);
