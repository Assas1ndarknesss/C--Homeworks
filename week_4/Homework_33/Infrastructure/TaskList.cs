namespace Infrastructure;

public class TaskList
{
    public List<TaskHome> tasks { get; set; } = new List<TaskHome>();
    public List<TaskHome> GetCompletedTasks = new List<TaskHome>();
    List<Category> categories= new List<Category>();
    public void AddTask(TaskHome task)
    {
        tasks.Add(task);
    }
    public void RemoveTask(string title)
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].Title == title)
            {
                System.Console.WriteLine();
                tasks.RemoveAt(i);
                System.Console.WriteLine($"Задача \"{title}\" удалена.");
                return;
            }
        }

        System.Console.WriteLine("Don't finden!");
    }

    public void ShowAllTasks()
    {
        int cnt = 1;
        foreach (var item in tasks)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"{cnt}. {item.Title} - {item.Description}");
            cnt++;
        }
    }

    public TaskHome FindByTitle(string title)
    {
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                return item;
            }
        }
        return null;

    }
    public void MarkAsCompleted(string title)
    {
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                item.IsCompleted = true;
                System.Console.WriteLine($"Задача {item.Title} отмечена как выполненная");
            }
        }
    }
    public List<TaskHome> GetCompletedTaskss()
    {
        List<TaskHome> completed = new List<TaskHome>();
        foreach (var item in tasks)
        {
            if (item.IsCompleted == true)
            {
                completed.Add(item);
            }
        }
        return completed;
    }
    public List<TaskHome> UnGetCompletedTaskss()
    {
        List<TaskHome> uncompleted = new List<TaskHome>();
        foreach (var item in tasks)
        {
            if (item.IsCompleted != true)
            {
                uncompleted.Add(item);
            }
        }
        return uncompleted;
    }
    public List<TaskHome> FindByDescription(string description)
    {
        List<TaskHome> findByDescription = new List<TaskHome>();
        foreach (var item in tasks)
        {
            if (item.Description.Contains(description))
            {
                findByDescription.Add(item);
            }
        }
        return findByDescription;
    }

    public void AddCategory(string name, string description)
    {
      Category  category = new Category(name,description);
        categories.Add(category);
    }
    public void RemoveCategory(string name)
    {
        foreach (var item in categories)
        {
        if (name==item.Name)
        {
            
        categories.Remove(item);
        }
        System.Console.WriteLine();
            
        }
    }

public void ShowCategories(){
    int cnt = 1 ;
    foreach (var item in categories)
    {
        System.Console.WriteLine($"{cnt}. {item.Name} - {item.Description}");
    }
}


}
