rectangle my = new rectangle();
System.Console.WriteLine("Your width?:");
my.width = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Your height?:");
my.height = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Your Color?:");
my.color = Console.ReadLine();

int all = my.getarea();
System.Console.WriteLine($"Area:{all}");

int all1 = my.getper();
System.Console.WriteLine($"Perimeter:{all1}");


class rectangle
{
    public int width;
    public int height;
    public string color;
  
  public int getarea(){
     int res = width*height;
 return res;
  }
  public int getper(){
     int res = (width+height)*2;
 return res;
  }



}