Manager manager = new Manager();
Post MyPost = new Post("Jeremy","About Day",12);
manager.Posts.Add(MyPost);
System.Console.WriteLine(manager.Getpost());
System.Console.WriteLine(manager.GetpostById(12));
DateTime My = DateTime.Now;
MyPost.CreatedAt=My;
System.Console.WriteLine(manager.GetPostByDate(My));
manager.DeletePost(12);