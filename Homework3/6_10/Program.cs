int[] arr1 = new int[] { 1, 2, 3 };
int[] arr2 = new int[] { 4, 5, 6 };
int[] arr3 = new int[arr1.Length + arr2.Length];
// int ind=0;
void MergeArrays(int[] arr1, int[] arr2)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            System.Console.Write(arr1[i] + ", ");
        }
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] % 2 == 0)
        {
            System.Console.Write(arr2[i] + ", ");
        }
    }
     for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 != 0)
        {
            System.Console.Write(arr1[i] + ", ");
        }
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] % 2 != 0)
        {
            System.Console.Write(arr2[i] + " ");
        }
    }
    System.Console.Write("]");
}
MergeArrays(arr1, arr2);
