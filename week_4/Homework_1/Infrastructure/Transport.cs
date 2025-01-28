namespace Infrastructure;

public class Transport
{
    private string model;
    private decimal price;
    private int speed;

    public Transport(string model, decimal price, int speed)
    {
        this.model = model;
        this.price = price;
        this.speed = speed;
    }
    public void About()
    {
        System.Console.WriteLine("I'm just Transport");
    }
    public void Show(){
        System.Console.WriteLine($"Model: {this.model}");
        System.Console.WriteLine($"Price: {this.price}");
        System.Console.WriteLine($"Speed: {this.speed}");
    }
}
