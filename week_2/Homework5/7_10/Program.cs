// Входные данные
// Вводятся 100 чисел, сумму которых необходимо посчитать.

// Выходные данные
// Программа должна вывести единственное число - полученную сумму.


int a = Convert.ToInt16(Console.ReadLine());
int sum = 0;
int rec (int a)
{
    if (a==0)
    {
        System.Console.WriteLine("Sum = "+sum);
        return 0;
    }
    sum+=a;
    return rec(a-1);
}
rec(a);