// Входные данные
// Вводятся 4 числа: a, b, c и d. 

// Выходные данные
// Выведите все числа на отрезке от a до b, дающие остаток c при делении на d. Если таких чисел не существует, то ничего выводить не нужно.


int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
int c = Convert.ToInt16(Console.ReadLine());
int d = Convert.ToInt16(Console.ReadLine());
int rec_pop(int a, int b, int c, int d)
{
    if (a==b)
    {
        return 0;
    }
    else if (a%d==c)
    {
        System.Console.Write(a+" ");
    }
    return rec_pop(a+1,b,c,d);
}
rec_pop(a,b,c,d);