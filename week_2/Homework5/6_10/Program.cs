// Входные данные
// Вводится натуральное число x.

// Выходные данные
// Выведите единственное число - количество делителей числа x.



int a = Convert.ToInt32(Console.ReadLine());
int b=a;
int cnt=0;
int rec(int a)
{
    if (a==0)
    {
        System.Console.WriteLine(cnt);
        return 0;
    }
    if (b % a == 0)
    {
        cnt++;
    }
    return rec(a-1);

}
rec(a);