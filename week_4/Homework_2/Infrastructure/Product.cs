namespace Infrastructure;

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetPrice(double price)
    {
        if (price >= 0)
        {
            this.price = price;
        }
        else
        {
            System.Console.WriteLine("Error Man");
        }
    }
    public double GetPrice()
    { 
        return this.price;
    }
    public void SetQuantity(int quantity)
    {
        if (quantity >= 0)
        {
            this.quantity = quantity;
        }
        else
        {
            System.Console.WriteLine("Error Man");
        }
    }
    public int GetQuantity()
    {
        return this.quantity;
    }
}