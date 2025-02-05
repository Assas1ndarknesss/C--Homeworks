namespace Infrastructure;

public class Category
{
    string name;
    string description;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public Category(string description, string name)
    {
        this.Name = name;
        this.Description = description;
    }
}

