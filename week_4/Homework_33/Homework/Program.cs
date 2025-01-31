using  Infrastructure;

Infrastructure.TaskHome task = new Infrastructure.TaskHome ();
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

TaskList taskList = new TaskList();
taskList.AddTask(task);
taskList.RemoveTask("Сделать домашку");
taskList.ShowAllTasks();

taskList.MarkAsCompleted("Сделать домашку");
