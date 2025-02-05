namespace Infastructure;

public class Order 
{
   private int OrderId;
    List<MenuItem> menuItems= new List<MenuItem>();
   private double TotalPrice;

   public Order(int order){
    this.OrderId = order;
   }
   public void AddItem(MenuItem item){
    menuItems.Add(item);
   }
   public void RemoveItem(MenuItem item){
    menuItems.Remove(item);
   }
   public double CalculateTotal(){
         return 0;
   }
}
