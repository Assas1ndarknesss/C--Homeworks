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
        for (int i = num - 1; i >= 0; i--)
        {
            Console.Write($"{add[i]}  ");
        }
    }
}