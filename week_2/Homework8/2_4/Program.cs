System.Console.Write("Radius:");
double rd= Convert.ToDouble(Console.ReadLine());
Circle circle12 = new Circle(rd);
System.Console.Write("Your radius:");
System.Console.WriteLine(circle12.GetRadius());
System.Console.Write("Area:");
System.Console.WriteLine(circle12.GetArea());
System.Console.Write("Diametr:");
System.Console.WriteLine(circle12.GetDiametr());
System.Console.Write("Circumference:");
System.Console.WriteLine(circle12.GetCircumference());
class Circle
{
    private double radius;
    private double PI=3.14159;
 
    public Circle(double radius){
     this.radius=radius;
    }
    public Circle(){
     this.radius=0.0;
    }
    public void SetRadius (double radius){
        System.Console.WriteLine("Radius:");
        this.radius = Convert.ToDouble(Console.ReadLine());
    }
    public double GetRadius(){
        return radius;
    }
    public double GetArea(){
        double area= PI*(radius*radius);
        return area;
    }
    public double GetDiametr(){
        double diam = radius*2;
        return diam;
    }
    public double GetCircumference(){
        double cir = PI*2*radius;
        return cir;
    }


}