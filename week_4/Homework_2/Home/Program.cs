using Infrastructure;

Product product = new Product();

System.Console.Write("Add Name:");
string name = Console.ReadLine();
product.SetName(name);

System.Console.Write("Add Price:");
double price = Convert.ToDouble(Console.ReadLine());
product.SetPrice(price);

System.Console.Write("Add Quantity:");
int quantity = Convert.ToInt32(Console.ReadLine());
product.SetQuantity(quantity);

StoreManager storeManager = new StoreManager();

storeManager.AddProduct(product);

System.Console.Write("Delete product:");
string deleteproduct = Console.ReadLine();
storeManager.RemoveProductByName(deleteproduct);

Order order = new Order();

