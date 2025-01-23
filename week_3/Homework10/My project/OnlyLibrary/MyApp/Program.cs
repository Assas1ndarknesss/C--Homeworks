using Library;

System.Console.Write("ISBN:");
string Isbn = Console.ReadLine();

System.Console.Write("Title:");
string Title = Console.ReadLine();

System.Console.Write("Author:");
string Author = Console.ReadLine();

System.Console.Write("Publication Year:");
string PYear = Console.ReadLine();

Book book = new Book(Title, Author, PYear);
book.GetIsbn(Isbn);

System.Console.Write("Name:");
string L = Console.ReadLine();

System.Console.Write("Quantity:");
int q = Convert.ToInt32(Console.ReadLine());

Librari librari = new Librari(L, q);
librari.Add(book);

librari.ShowInfo();

System.Console.Write("Author:");
string a = Console.ReadLine();

librari.FindAuthor(a);
