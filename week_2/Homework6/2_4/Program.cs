User user = new User();
{
    System.Console.Write("FirstName: ");
    user.FirstName = Console.ReadLine();
    System.Console.Write("LastName: ");
    user.LastName = Console.ReadLine();
    System.Console.Write("UserName: ");
    user.UserName = Console.ReadLine();
    System.Console.Write("Password: ");
    user.Password = Console.ReadLine();

    user.Login("Bezh", "ipo90");
    System.Console.WriteLine(user.GetFullInfo());

}

class User
{
    public string? FirstName;
    public string? LastName;
    public string? UserName;
    public string? Password;
    public bool IsLoggedIn;


    

    public void Login(string username, string password)
    {
        if (UserName == username && Password == password)
        {
            IsLoggedIn = true;
            System.Console.WriteLine("Пользователь успешно зарегистрирован");
        }
        else
        {
            System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }
    public void Logout()
    {
        IsLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{LastName} {FirstName} - {IsLoggedIn}";
    }


}
