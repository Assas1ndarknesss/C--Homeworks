
// Шумо бояд класси Product созед, ки молро дар мағоза идора мекунад.

// Майдонҳои класс
// private string Name - номи мол
// private decimal Price - нархи мол бо рубл
// private int StockQuantity - миқдори мол дар анбор
// private string Category - категорияи мол
// private bool IsDiscounted - оё мол тахфиф дорад
// Методҳо

Product product_1 = new Product();
System.Console.WriteLine(product_1.GetIbfoProduct());
System.Console.WriteLine(product_1.SetDiscount(10));
System.Console.WriteLine(product_1.AddNewItems(5));
System.Console.WriteLine(product_1.SellItem(3));
System.Console.WriteLine(product_1.CheckAvailability());
System.Console.WriteLine(product_1.GetPriceTag());

class Product
{
    private string? name;
    private decimal price;
    private int StocQuantity;
    private string? Category;
    private bool IsDiscounted;
    private decimal disprice;


    public string GetIbfoProduct()
    {
        System.Console.Write("Name: ");
        name = Console.ReadLine();
        this.name = name;
        System.Console.Write("Price: ");
        price = Convert.ToDecimal(Console.ReadLine());
        this.price = price;
        System.Console.Write("StockQuantity: ");
        StocQuantity = Convert.ToInt32(Console.ReadLine());
        this.StocQuantity = StocQuantity;
        System.Console.Write("Category: ");
        Category = Console.ReadLine();
        this.Category = Category;
        this.IsDiscounted = false;
        System.Console.WriteLine();
        return $"Your product is added";
    }

    public string SetDiscount(int discountPercent)
    {
        if (discountPercent <= 0 || discountPercent > 100)
        {
            return "Неверная скидка";
        }
        disprice = price - (price * discountPercent / 100);
        IsDiscounted = true;
        return $"Новая цена: {disprice} рублей";
    }
    public string AddNewItems(int count)
    {
        int countplussclad;
        if (count <= 0)
        {
            return "Ошибка поставки";
        }
        countplussclad = count + StocQuantity;
        return $"Теперь на складе: {countplussclad} штук";
    }

    public string SellItem(int count)
    {
        if(count<=0 || count>StocQuantity)
        return$"Недостаточно товара на складе";
        else
        {
            StocQuantity=StocQuantity-count;
            decimal sell=disprice*count;
            return$"Продано! Стоимость:{sell}рублей";
        }
    }
    public string CheckAvailability()
    {
        if (StocQuantity > 20)
        {
            return $"Много товара{StocQuantity}.шт";
        }
        else if (StocQuantity >= 5 && StocQuantity <= 20)
        {
            return $"Достаточно товара {StocQuantity}.шт";
        }
        else
        {
            return $"Срочно нужна поставка! {StocQuantity}.шт";
        }
    }
    public string GetPriceTag()
    {
        if (IsDiscounted)
        { return $"Name: {name} , Category: {Category} , Old_price: {price} , New_price: {disprice} skidka"; }
        else
        {
            return $"Name: {name} , Category: {Category} ,price: {price}";
        }
    }
}
