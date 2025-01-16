// Входные данные
// Вводится число N, а затем N чисел.

// Выходные данные
// Подсчитайте и выведите, сколько среди данных N чисел нулей.


int n = Convert.ToInt16(Console.ReadLine());
int a;
int zero = 0;
int rec(int n)
{
    if (n==0)
    {
        System.Console.WriteLine(zero);
        return 0;
    }
    a = Convert.ToInt16(Console.ReadLine());
    if (a==0)
    {
        zero++;
    }
    return rec(n-1);
}
rec(n);