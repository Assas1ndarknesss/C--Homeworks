// Входные данные
// Вводятся целые числа a и b. Гарантируется, что a не превосходит b

// Выходные данные
// Выведите (через пробел) все четные числа от a до b (включительно).

int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
int rec (int a, int b)
{
    if (a==b)
    {
        return 0;
    }
    else if (a%2==0)
    {
        System.Console.Write(a+" ");
    }
    return rec(a+1,b);
}
rec(a,b);