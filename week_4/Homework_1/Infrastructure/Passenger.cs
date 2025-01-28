namespace Infrastructure;

public class Passenger:Auto 
{
   private string travel;
   private string travel2;

    public Passenger(string model,decimal price, int speed) : base(model,price,speed){}

   public void travelway(string way,string way2){
    this.travel=way;
    this.travel2=way2;
    System.Console.WriteLine($"We come from {this.travel} to {this.travel2}");
   }
}