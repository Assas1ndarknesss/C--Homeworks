using  Infrastructure;

Infrastructure.Task task = new Infrastructure.Task ();
task.Title="Сделать домашку";
task.Description="Решить задачи по C#";
task.IsCompleted=false;

System.Console.WriteLine($"Задача: {task.Title}");
System.Console.WriteLine($"Описание: {task.Description}");
if (task.IsCompleted)
{
    System.Console.WriteLine("Статус: Выподнена");
}
else
{
    System.Console.WriteLine("Статус: Не выполнена");
}
