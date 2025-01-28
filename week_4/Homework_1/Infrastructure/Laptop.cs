namespace Infrastructure;

public class Laptop:Computer
{
    public string Monitor;

public Laptop(string name,decimal price,int pubyear) : base(name, price, pubyear){}
    public void AnotherJob(){
     System.Console.WriteLine("Im Ultron's Laptop");
    }

}
