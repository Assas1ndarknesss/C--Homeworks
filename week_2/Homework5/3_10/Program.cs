// Входные данные
// Вводятся целые числа a и b. Гарантируется, что a не превосходит b.

// Выходные данные
// Выведите все числа на отрезке от a до b, являющиеся полными квадратами. Если таких чисел нет, то ничего выводить не нужно.


int rec(int a, int b)
{
    int kvadrat = a * a;
    if (kvadrat > b)
    {
        return 0;
    }
    System.Console.Write(kvadrat + " ");
    return rec(a + 1, b);

}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
rec(a, b);
