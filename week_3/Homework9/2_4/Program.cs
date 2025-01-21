User[] users = new User[5]
{
    new User("Shohrukh", "Han", "Rayman", "12345"),
    new User("Bezhan", "Iftikhor", "BezhIK", "54321"),
    new User("Alisher", "Zaripov", "Zarik", "15243"),
    new User("Matlabshoh", "Abdunazarzoda", "Zevs", "51423"),
    new User("Yusuf", "Shobadalov", "Bilolger", "13542")
};
string inputUserName;
string inputPassword;
while (true)
{
    Console.Write("Enter username: ");
    inputUserName = Console.ReadLine();

    Console.Write("Enter password: ");
    inputPassword = Console.ReadLine();

    bool truefalse = false;

    foreach (var user in users)
    {
        if (user.Login(inputUserName, inputPassword))
        {
            Console.WriteLine($"Login successful! Welcome, Mr.{user.GetInfo()}");
            truefalse = true;
            break;
        }
    }
    if (truefalse == false)
    {
        System.Console.WriteLine("Login failed!");
     
    }
    else
    {
        break;
    }
}

class User
{
    string FirstName;
    string Lastname;
    string UserName;
    string Password;

    public User(string firstName, string lastName, string userName, string password)
    {
        this.FirstName = firstName;
        this.Lastname = lastName;
        this.UserName = userName;
        this.Password = password;
    }

    public string GetInfo()
    {
        return $"{FirstName} {Lastname} ({UserName})";
    }
    public bool Login(string userName, string password)
    {
        return UserName == userName && Password == password;
    }
}
