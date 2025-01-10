string a = Console.ReadLine();
void pl(string n)
{
    string r = "";
    for (int i = n.Length - 1; i >= 0; i--)
    {
        r += n[i];
    }
    if (n == r)
    {
        Console.WriteLine("Палиндром: Да");
    }
    else
    {
        Console.WriteLine("Палиндром: Нет");
    }
}
pl(a);