public class Manager
{
    public List<Post> Posts = new List<Post>();
    public List<Category> Categorys = new List<Category>();
    public string Getpost()
    {
        foreach (var item in Posts)
        {
        return $"Title: {item.Title}  Despcription: {item.description} Id: {item.Id}";
            
        }
        return null;
    }

    public Post GetpostById(int id)
    {
        foreach (var item in Posts)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    public Post GetPostByName(string name)
    {
        foreach (var item in Posts)
        {

            if (item.Title == name)
            {
                return item;
            }
        }
        return null;
    }

    public Post GetPostByDate(DateTime dateTime)
    {
        foreach (var item in Posts)
        {

            if (item.CreatedAt == dateTime)
            {
                return item;
            }
        }
        return null;
    }
    public void DeletePost(int id)
    {
        foreach (var item in Posts)
        {

            if (item.Id == id)
            {
                Posts.Remove(item);
                System.Console.WriteLine("Deleted");
            }
            else
            {
                System.Console.WriteLine("Don't finden");
            }
        }

    }
    public List<Category> GetCategories()
    {
        foreach (var item in Categorys)
        {
            return Categorys;
        }
        return null;
    }
    public Category GetCategoriesById(int id)
    {
        foreach (var item in Categorys)
        {
            if (id == item.Id)
            {
                return item;
            }
        }
        return null;
    }
    public Category GetCategoriesByName(string name)
    {
        foreach (var item in Categorys)
        {
            if (name == item.Name)
            {
                return item;
            }
        }
        return null;
    }
    public Category GetCategoriesByDate(DateTime name)
    {
        foreach (var item in Categorys)
        {
            if (name == item.CreatedAt)
            {
                return item;
            }
        }
        return null;
    }
    public void DeleteCategory(int id)
    {
        foreach (var item in Categorys)
        {
            if (id == item.Id)
            {
                Categorys.Remove(item);
            }
            else
            {
                System.Console.WriteLine("Don't finden");
            }
        }
    }


}