// Входные данные
// Вводится натуральное число x.

// Выходные данные
// Выведите наименьший делитель числа x, отличный от 1.



int a = Convert.ToInt16(Console.ReadLine());
int b = a;
int min = a;
int rec (int a)
{
    if (a==1)
    {
        System.Console.WriteLine(min);
        return 0;
    }
    else if (b%a==0)
    {
        if (min>a)
        {
            min=a;
        }
    }
    return rec (a-1);
}
rec(a);