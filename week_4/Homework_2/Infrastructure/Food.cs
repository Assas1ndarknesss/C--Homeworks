namespace Infrastructure;
public class Food : Product 
{
    private DateTime _ExpirationDate;
    public DateTime ExpirationDate
    {
        get { return this._ExpirationDate;}
        set{_ExpirationDate = value;}
    }
    public bool IsExpired(){
        if (_ExpirationDate>DateTime.Now)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
