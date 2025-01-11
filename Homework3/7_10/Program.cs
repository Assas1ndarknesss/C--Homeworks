int[] arr = new int[] { 1, 2, 3, 4, 5 };
int num = Convert.ToInt32(Console.ReadLine());
void method(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {

        if (arr[i] + arr[i + 1] == num)
        {
            System.Console.WriteLine(arr[i] + " " + arr[i + 1]);
        }
        if (arr[i] + arr[i + 2] == num)
        {
            System.Console.WriteLine(arr[i] + " " + arr[i + 2]);
        }
        if (arr[i] + arr[i + 3] == num)
        {
            System.Console.WriteLine(arr[i] + " " + arr[i + 3]);
        }
        if (arr[i] + arr[i + 4] == num)
        {
            System.Console.WriteLine(arr[i] + " " + arr[i + 4]);
        }

        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j + 1] + arr[j] == num)
            {
                System.Console.WriteLine(arr[j + 1] + " " + arr[j]);
            }
            if (arr[j + 1] + arr[j + 2] == num)
            {
                System.Console.WriteLine(arr[j + 1] + " " + arr[j + 2]);
            }
            if (arr[j + 1] + arr[j + 3] == num)
            {
                System.Console.WriteLine(arr[j + 1] + " " + arr[j + 3]);
            }
            if (arr[j + 1] + arr[j + 4] == num)
            {
                System.Console.WriteLine(arr[j + 1] + " " + arr[j + 4]);
            }
        }
    }
}
method(arr);
