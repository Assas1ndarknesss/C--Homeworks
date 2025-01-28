namespace Infrastructure;

public class Auto:Transport
{
    private string color;

    public Auto(string model, decimal price, int speed) : base(model, price, speed) {}

    public void GetColor(string col){
        this.color=col;
    }
    public void Show(string color){
        this.color=color;
        System.Console.WriteLine($"Color: {this.color}");
    }
}
