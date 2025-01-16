// Входные данные
// Вводится натуральное число x

// Выходные данные
// Выведите все делители числа x


int a = Convert.ToInt32(Console.ReadLine());
int b=a;
int rec(int a)
{
    if (a==0)
    {
        return 0;
    }
    if (b % a == 0)
    {
        System.Console.Write(a + " ");
    }
    return rec(a-1);

}
rec(a);
