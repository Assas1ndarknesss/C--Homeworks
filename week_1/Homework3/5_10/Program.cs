int[] arr = { 1, 3, 3, 2, 1, 5, 2 };
void metod(int[] arr)
{
    int[] result = RemoveDuplicates(arr);
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }
    Console.WriteLine();

}
metod(arr);
int[] RemoveDuplicates(int[] arr)
{
    int[] temp = new int[arr.Length];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        bool Duplicat = false;
        for (int j = 0; j < index; j++)
        {
            if (arr[i] == temp[j])
            {
                Duplicat = true;
                break;
            }
        }
        if (!Duplicat)
        {
            temp[index] = arr[i];
            index++;
        }
    }
    int[] result = new int[index];
    for (int i = 0; i < index; i++)
    {
        result[i] = temp[i];
    }

    return result;
}