using Infrastructure;

StoreManager storeManager = new StoreManager();
                Order order = new Order("Zulayho");

while (true)
{
    System.Console.WriteLine();
    System.Console.WriteLine("1.Добавление продукта.");
    System.Console.WriteLine("2.Удаление продукта.");
    System.Console.WriteLine("3.Просмотр всех продуктов.");
    System.Console.WriteLine("4.Создание заказа.");
    System.Console.WriteLine("5.Подсчёт общей суммы заказа.");
    System.Console.WriteLine("6.Stop");

    string Function = Console.ReadLine();

    switch (Function)
    {
        case "1":
            {
                System.Console.WriteLine("1.Добавление продукта.");
                Product product = new Product();
                System.Console.Write("Product name:");
                string pro = Console.ReadLine();
                product.SetName(pro);
                System.Console.Write("Product price:");
                double pri = Convert.ToDouble(Console.ReadLine());
                product.SetPrice(pri);
                System.Console.Write("Product quantity:");
                int qua = Convert.ToInt32(Console.ReadLine());
                product.SetQuantity(qua);
                storeManager.AddProduct(product);
                break;
            }

        case "2":
            {
                System.Console.WriteLine("2.Удаление продукта.");
                storeManager.RemoveProductByName(Console.ReadLine());
                break;

            }
        case "3":
            {
                System.Console.WriteLine("3.Просмотр всех продуктов.");
                storeManager.GetAllProducts();
                break;

            }
        case "4":
            {
                System.Console.WriteLine("4.Создание заказа.");
                System.Console.Write("Name of Product:");
                string name2 = Console.ReadLine();
                Product product = storeManager.GetProductByName(name2);
                 order.AddProductToOrder(product);
                 product.SetQuantity(product.GetQuantity()-1);
                break;

            }
        case "5":
            {
    System.Console.WriteLine("5.Подсчёт общей суммы заказа.");
                order.GetTotalAmount("Zulayho");
                break;

            }

        default:
            {
                System.Console.WriteLine("Э дафша ука азоб доди бо яг чизе мегуйки надоремша");
                break;
            }
    }

}
