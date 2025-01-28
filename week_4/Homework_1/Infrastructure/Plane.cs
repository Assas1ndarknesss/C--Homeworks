using System.Security.Cryptography.X509Certificates;

namespace Infrastructure;

public class Plane:Transport
{
    protected string type;
    protected string company;
  
  public Plane(string model,decimal price,int speed) : base (model,price,speed){}
  public void MyJob(){
    System.Console.WriteLine("I can fly");
  }
  public void GetInforms(string type,string company){
    this.type=type;
    this.company=company;
  }
  public void ShowPlane(){
    System.Console.WriteLine($"It's me {this.type}");
    System.Console.WriteLine($"It's my company {this.company}");
  }
 
}
