namespace Infrastructure;

public class StoreManager
{
    public List<Product> Products = new List<Product>();
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public void GetAllProducts()
    {
        foreach (var item in Products)
        {
            System.Console.WriteLine($"Name: {item.GetName}, Price: {item.GetPrice}");
            System.Console.WriteLine($"Quantity: {item.GetQuantity}");
        }
    }

    public Product GetProductByName(string name)
    {
        foreach (var item in Products)
        {
            if (item.GetName() == name)
            {
                return item;
            }
        }
        return new Product();
    }

    public void RemoveProductByName(string name)
    {
        foreach (var item in Products)
        {
            if (item.GetName() == name)
            {
                Products.Remove(item);
                System.Console.WriteLine("Product succselfully deleted");
            }
            else
            {
                System.Console.WriteLine("Don't finden");
            }
        }
    }


    public List<Product> GetProductsByPriceRange(double min, double max)
    {
        List<Product> result = new List<Product>();
        foreach (var item in Products)
        {
            if (item.GetPrice() >= min && item.GetPrice() <= max)
            {
                result.Add(item);
            }
        }
        return result;
    }

    public void GetAvailableProduct()
    {
        foreach (var item in Products)
        {
            if (item.GetQuantity() > 0)
            {
                System.Console.WriteLine(item);
            }
        }
    }

}