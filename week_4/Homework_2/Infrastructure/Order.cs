namespace Infrastructure;

public class Order : Product
{
    string CumtomerName;
    List<Product> products = new List<Product>();

    public void GetTotalAmount(string name)
    {
        double sum = 0;
        foreach (var item in products)
        {
            sum += item.GetPrice() + item.GetQuantity();
        }
    }

    public void AddProductToOrder(Product product){
        products.Add(product);
        
    }
}
