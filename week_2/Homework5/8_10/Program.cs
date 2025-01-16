// Входные данные
// Вводится число N, а затем N чисел, сумму которых необходимо вычислить.

// Выходные данные
// Выведите единственное число - сумму введенных чисел.


int n = Convert.ToInt16(Console.ReadLine());
int a;
int sum = 0;
int rec (int n)
{
    if (n==0)
    {
        System.Console.WriteLine("Sum = "+sum);
    }
    a = Convert.ToInt16(Console.ReadLine());
    sum+=a;
    return rec(n-1);
}
rec(n);