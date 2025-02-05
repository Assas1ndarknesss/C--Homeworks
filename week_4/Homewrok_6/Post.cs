using System.Runtime.CompilerServices;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string description { get; set; }
    public DateTime CreatedAt { get; set; }
    public int categoryId { get; set; }
    public Post(string Title, string description, int categoryId)
    {
        this.Id = categoryId;
        this.description = description;
        this.Title = Title;
    }
}
