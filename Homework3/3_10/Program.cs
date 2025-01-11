int[] arr = new int[] { 1, 2, 3, 4, 5 };
System.Console.Write("positions = ");
int positions = Convert.ToInt32(Console.ReadLine());
void ShiftArray(int[] arr, int positions)
{
    System.Console.Write("[");
    for (int i = positions + 1; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }

    for (int i = 0; i <= positions - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    for (int i = positions; i > 0; i--)
    {
        Console.Write(arr[i]);
        break;
    }
    System.Console.WriteLine("]");
}
ShiftArray(arr, positions);
