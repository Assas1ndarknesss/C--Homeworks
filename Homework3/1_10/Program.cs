int[] arr = new int[] { 1, 2, 3, 4, 5, 6};
void EvenOdd(int[] arr)
{
    System.Console.Write("четные: [");
    for (int i = 0; i < arr.Length - 2; i++)
    {
        if (arr[i] % 2 == 0)
        {
            System.Console.Write(arr[i] + ", ");
        }
    }
    for (int i = arr.Length - 1; i > 0; i--)
    {
        if (arr[i] % 2 == 0)
        {
            System.Console.Write(arr[i]);
            break;
        }
    }
    System.Console.WriteLine("]");

    System.Console.Write("Нечетные: [");
    for (int i = 0; i < arr.Length - 2; i++)
    {
        if (arr[i] % 2 != 0)
        {
            System.Console.Write(arr[i] + ", ");
        }
    }
    for (int i = arr.Length - 1; i > 0; i--)
    {
        if (arr[i] % 2 != 0)
        {
            System.Console.Write(arr[i]);
            break;
        }
    }
    System.Console.Write("]");
}
EvenOdd(arr);
