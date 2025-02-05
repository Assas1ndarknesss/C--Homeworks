namespace Infastructure;

public class MenuItem
{
    private string Name;
    private double Price;
    public double GetPrice
    {
        get { return this.Price; }
        set { this.Price = value; }
    }
    private string Category;

    public MenuItem(string name, double price, string category)
    {
        this.Name = name;
        this.Price = price;
        this.Category = category;
    }

    public string GetDescription()
    {
        return $"Name: {this.Name} Price: {this.Price} Category: {this.Category}";
    }


}
