namespace Infrastructure;

public class OverWeight:Auto 
{
    private string plases;
    public OverWeight(string model,decimal price, int speed) : base(model,price,speed){}

    public void GetShow(string plases){
        this.plases=plases;
        System.Console.WriteLine($"Places in Car: {this.plases}");
    }
}