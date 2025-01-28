namespace Infrastructure;

public class Computer
{
    protected string Name;
    protected decimal Price;
    protected int PubYear;

    public Computer(string name, decimal Price, int pubyear)
    {
        this.Name = name;
        this.Price = Price;
        this.PubYear = pubyear;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"It's {Name}");
        System.Console.WriteLine($"My price {Price}");
        System.Console.WriteLine($"I'm born {PubYear}");
    }
    public void Work(){
        System.Console.WriteLine("Im opening program");
    }

}
