namespace Infrastructure;

public class Smartphone:Computer
{
 private string Country;
 public Smartphone(string name,decimal price , int pubyear) : base(name,price,pubyear){}

public void Get(string coun){
    this.Country=coun;
}
 public void Smart(){
    System.Console.WriteLine($"I come here from {this.Country}");
 }
}
