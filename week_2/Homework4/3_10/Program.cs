internal class Program
{
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] add = new int[num];
        for (int i = 0; i < num; i++)
        {
            add[i] = Convert.ToInt32(Console.ReadLine());
        }
        int cnt = 0;
        for (int i = 0; i < num; i++)
        {
            if (add[i] >= 0)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }
}