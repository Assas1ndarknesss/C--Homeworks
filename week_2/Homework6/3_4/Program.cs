



Autor autor = new Autor();
{
    System.Console.Write("Name: ");
    autor.name = Console.ReadLine();
    System.Console.Write("Age: ");
    autor.age = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Nationality: ");
    autor.nationality = Console.ReadLine();
    System.Console.WriteLine(autor.GetName());
    System.Console.WriteLine(autor.GetAge());
    System.Console.WriteLine(autor.GetNationality());
    System.Console.WriteLine(autor.CelebrateBirthday());
    System.Console.WriteLine(autor.Introduce());
}
class Autor
{
    public string? name;
    public int age;
    public string? nationality;

    public string GetName()
    {
        return $"Name : {name}";
    }
    public string GetAge()
    {
        return $"Age : {age}";
    }
    public string GetNationality()
    {
        return $"Nationality : {nationality}";
    }
    public string Introduce()
    {
        return $"My name is {name}. I'm {age} years old. I'm from {nationality}.";
    }
    public string CelebrateBirthday()
    {
        return $"plusAge: {age + 1}";
    }
}
