namespace Library;
public class Librari
{
    public string name;
    public int index = 0;
    Book[] Books;

    public Librari(string name, int size)
    {
        this.name = name;
        Books = new Book[size];
    }
    public void Add(Book book)
    {
        if (index < Books.Length)
        {
            Books[index] = book;
            index++;

        }
            System.Console.WriteLine("Book not added");
    }
    public void FindAuthor(string author)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Author == author)
            {
                Books[i].ShowInfo();
            }
        }
    }
    public void ShowInfo()
    {
        System.Console.WriteLine($"Lib-Name: {this.name}");
        for (int i = 0; i < Books.Length; i++)
        {
            Books[i].ShowInfo();
        }
    }
}
