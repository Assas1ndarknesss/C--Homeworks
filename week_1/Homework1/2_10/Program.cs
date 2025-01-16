int[] add;
int sum = 1;
add = new int[5];
for (int i = 0; i < 5; i++)
{
    add[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i =0; i <add.Length; i++)
{
    sum *= add[i];
}
   Console.WriteLine(sum);
