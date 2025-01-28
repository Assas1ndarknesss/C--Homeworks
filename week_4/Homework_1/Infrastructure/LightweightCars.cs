namespace Infrastructure;

public class LightweightCars:Auto 
{
    private string Place;
    public LightweightCars(string model,decimal price, int speed) : base(model,price,speed){}

    public void GetShow(string Place){
        this.Place=Place;
        System.Console.WriteLine($"Place: {this.Place}");
    }
}