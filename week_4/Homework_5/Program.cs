
Math.NumbersSum(1, 2, 3, 4, 5);
Math.NumbersSub(10, 2, 3);
Math.MultyOfNumbers(2, 3, 4);
Math.DivideOfNumbers(100, 2, 5);
Math.FactorialOfNumbers(5);
Math.MinimumOfNumbers(10, 3, 7, 1);
Math.MaximumOfNumbers(10, 3, 7, 1);
Math.DegreeNums(2, 3, 4);
Math.AverageOfNums(1, 2, 3, 4, 5);
Math.DeleteMinusMath(-10, 5, -3);
public static class Math
{

    public static void MinimumOfNumbers(params int[] num)
    {
        int min = int.MaxValue;
        foreach (var item in num)
        {
            if (item < min)
            {
                min = item;
            }

        }
        System.Console.WriteLine($"Наименьшее число: {min}");
    }
    public static void MaximumOfNumbers(params int[] num)
    {
        int max = int.MinValue;
        foreach (var item in num)
        {
            if (item > max)
            {
                max = item;
            }

        }
        System.Console.WriteLine($"Максмальное число: {max}");
    }

    public static void DegreeNums(params int[] num)
    {

        for (int i = 0; i < num.Length; i++)
        {
            System.Console.WriteLine($"Kвадрат чисел: {num[i]} = {num[i] * num[i]}");
        }
        
    }

    public static void AverageOfNums(params int[] num)
    {
        int sum = 0;
        int cnt = 0;
        foreach (var item in num)
        {
            sum += item;
            cnt++;
        }
        System.Console.WriteLine($"Среднее число: {sum/cnt}");
    }

    public static void DeleteMinusMath(params int[] num)
    {

        for (int i = 0; i < num.Length; i++)
        {
            int MinusDeleter = num[i];
            if (MinusDeleter < 0)
            {
                MinusDeleter = -MinusDeleter;
            }
            System.Console.WriteLine($"Результат: {num[i]} = {MinusDeleter}");
        }
    }
    public static void NumbersSum(params int[] num)
    {
        int sum = 0;
        foreach (var item in num)
        {
            sum += item;
        }
        System.Console.WriteLine($"Сумма чисел: {sum}");
    }
    public static void NumbersSub(params int[] num)
    {
        int sub = num[0];
        foreach (var item in num)
        {
            sub -= item;
        }
        System.Console.WriteLine($"Вычитание чисел: {sub}");
    }
    public static void MultyOfNumbers(params int[] num)
    {
        int multy = 1;
        foreach (var item in num)
        {
            multy *= item;
        }
        System.Console.WriteLine($"Умножение чисел: {multy}");
    }
    public static void DivideOfNumbers(params double[] num)
    {
        double result = num[0];
        foreach (var item in num)
        {
           if(item!=num[0])
           {
            result/=item;
           }
        }
            System.Console.WriteLine($"Деление чисел: {result}");
    }

    public static void FactorialOfNumbers(params int[] num)
    {
     int sum=0;   
        foreach (var item in num)
        {
            int sumofnums = 1;
            for (int i = 1; i <= item; i++)
            {
                sumofnums *= i;
            }
            sum=sumofnums;
        }
            System.Console.WriteLine($"Факториал чисел: {sum}");
    }

}
