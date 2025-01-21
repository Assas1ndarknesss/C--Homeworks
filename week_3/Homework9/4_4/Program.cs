Order order1 = new Order(101, "Laptop", 2,2500.0);
Order order2 = new Order("Smatrphone", 5);
Order order3 = new Order("Headphone", 120.5);
Console.WriteLine("Order information:");
order1.DisplayInfo();
order2.DisplayInfo();
order3.DisplayInfo();


class Order
{
    int OrderNumber;
    string? ProductName;
    int Quantity;
    double TotalAmount;
    public Order(int orderNumber, string productName, int productQuantity, double orderAmount)
    {
        this.OrderNumber = orderNumber;
        this.ProductName = productName;
        this.Quantity = productQuantity;
        this.TotalAmount = orderAmount;
    }
    public Order(string productName, int productQuantity)
    {
        this.ProductName = productName;
        this.Quantity = productQuantity;
    }
    public Order(string productName, double orderAmount)
    {
        this.ProductName = productName;
        this.TotalAmount = orderAmount;
    }
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Order number: {OrderNumber} , Product name: {ProductName} , Quantity: {Quantity} ,  Total: {TotalAmount} ");
    }
}
