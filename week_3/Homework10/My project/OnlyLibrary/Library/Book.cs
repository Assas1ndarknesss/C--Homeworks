namespace Library;

public class Book
{
    private string ISBN;
    public string Title;
    public string Author;
    public string PublicationYear;


    public Book(string title, string author, string publicationYear)
    {
        this.Title = title;
        this.Author = author;
        this.PublicationYear = publicationYear;
    }
    public void SetISBN()
    {
        if (this.ISBN.Length >= 8 && this.ISBN.Length <= 10)
        {
            System.Console.Write(ISBN);
        }
        else
        {
            System.Console.Write("Incorect quantity!!!");
        }
    }
    public void GetIsbn(string isbn)
    {
        this.ISBN = isbn;
    }
    public void ShowInfo()
    {
        System.Console.WriteLine($"Author: {this.Author}");
        System.Console.WriteLine($"ISBN: {this.ISBN}");
        System.Console.WriteLine($"Title: {this.Title}");
        System.Console.WriteLine($"Year: {this.PublicationYear}");
    }

}
