namespace Infrastructure;

public class Electronic
{
    private int _WarrantyPeriod;
    public DateTime PubYear = DateTime.Now;
    public int WarrantyPeriod
    {
        get { return this._WarrantyPeriod;}
        set{_WarrantyPeriod = value;}
    }
    
    public string WarrantyPeriodInMonth(){
        var Month = PubYear.AddMonths(_WarrantyPeriod);
        if (Month<DateTime.Now)
        {
          return "Active";   
        }
        else
        {
            return "Not Active";
        }
    }
}
