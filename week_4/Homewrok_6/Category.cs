public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public Category(string Name,int id,DateTime data)
    {
        this.Name = Name;
        this.Id = id;
        this.CreatedAt = data;
    }


}