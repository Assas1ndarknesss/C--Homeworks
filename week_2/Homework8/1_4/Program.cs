System.Console.Write("Title:");
string tit1=Console.ReadLine();
System.Console.Write("Author:");
string aut1=Console.ReadLine();
System.Console.Write("Year?:");
int year1 =Convert.ToInt32(Console.ReadLine());
Book First = new Book(tit1, aut1,year1);
First.GetInfo();
System.Console.WriteLine(First.IsPublishedRecently());
class Book
{
     private string title;
     private string author;
     private int year;

  public void addinf(string title,string author,int year){
    this.title=title;
    this.author=author;
    this.year=year;
  }
 public Book (string title,string author,int year){
  
  this.title=title;
  
    this.author=author;
  
    this.year=year;

 }
 public void GetInfo(){
    System.Console.WriteLine();
    System.Console.WriteLine("That's Inform about your book");
System.Console.WriteLine();
System.Console.WriteLine($"Title:{title}");
System.Console.WriteLine($"Author:{author}");
System.Console.WriteLine($"Year:{year}");
 } 
 public bool IsPublishedRecently(){
    if (year>2010){
        return true;
    }
    else {return false;}
 }


}