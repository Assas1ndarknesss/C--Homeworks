// Входные данные
// Вводится число N, а затем N целых чисел.
// Выходные данные
// Необходимо вывести сначала число нулей, затем число положительных и отрицательных чисел.



int n = Convert.ToInt16(Console.ReadLine());
int a;
int zero = 0;
int polo = 0;
int otri = 0;
int rec (int n)
{
    if (n==0)
    {
        System.Console.WriteLine(zero+" "+polo+" "+otri);
        return 0;
    }
    a = Convert.ToInt16(Console.ReadLine());
    if (a==0)
    {
        zero++;
    }
    if (a>0)
    {
        polo++;
    }
    if (a<0)
    {
        otri++;
    }
    return rec(n-1);
}
rec(n);