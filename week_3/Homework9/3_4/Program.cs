System.Console.WriteLine("Creating student...");
System.Console.Write("Id = ");
int id = Convert.ToInt16(Console.ReadLine());
System.Console.Write("Name: ");
string name = Console.ReadLine();
System.Console.Write("Age: ");
int age = Convert.ToInt16(Console.ReadLine());
System.Console.Write("Avarage: ");
double Avarage = Convert.ToDouble(Console.ReadLine());
Student st1 = new Student(id, name, age, Avarage);
st1.GetInfo();
System.Console.WriteLine($"Excellent = {st1.IsExcellentStudent()}");
class Student
{
    int Id;
    string Name;
    int Age;
    double Avarage;

    public Student(int id, string name, int age, double Avarage)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.Avarage = Avarage;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Id={Id}; Name: {Name}, Age: {Age}, Avarage Grade: {Avarage}");
    }

    public bool IsExcellentStudent()
    {
        if (Avarage > 4.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
