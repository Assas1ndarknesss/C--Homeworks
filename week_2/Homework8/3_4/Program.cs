System.Console.Write("Day: ");
int day = Convert.ToInt16(Console.ReadLine());
System.Console.Write("Month: ");
int month = Convert.ToInt16(Console.ReadLine());
System.Console.Write("Year: ");
int year = Convert.ToInt16(Console.ReadLine());
Date first = new Date();
first.SetDate(day,month,year);
System.Console.WriteLine(first.Tostring());
class Date
{
    int Day;
    int Month;
    int Year;
    public void SetDate(int day, int month, int year)
    {
        this.Day=day;
        this.Month=month;
        this.Year=year;
    }
    public int GetDay()
    {
        return Day;
    }
    public int GetMonth()
    {
        return Month;
    }
    public int GetYear()
    {
        return Year;
    }
    public string Tostring()
    {
        if (GetDay() < 10 && GetMonth() < 10)
        {
            return $"0{Convert.ToString(GetDay())}/0{GetMonth()}/{GetYear()}";
        }
        else if(GetDay() < 10 && GetMonth() > 10)
        {
            return $"0{Convert.ToString(GetDay())}/{GetMonth()}/{GetYear()}";
        }
        else if(GetDay() > 10 && GetMonth() < 10)
        {
            return $"{Convert.ToString(GetDay())}/0{GetMonth()}/{GetYear()}";
        }
        else 
        {
            return $"{Convert.ToString(GetDay())}/{GetMonth()}/{GetYear()}";
        }
    }
}
