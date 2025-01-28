namespace Infrastructure;

public class CargoPlane:Auto 
{
   private string cargo;

    public CargoPlane(string model,decimal price, int speed) : base(model,price,speed){}

   public void mycargo(string carg){
    this.cargo=carg;
    System.Console.WriteLine($"We send you {this.cargo}");
   }
}