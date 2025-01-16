int[] num = new int[] {5, 4, 5, 5, 3, 5, 4};
void metod (int[] num)
{
    int cnt5 = Convert.ToInt16(0);
    int cnt4 = Convert.ToInt16(0);
    int cnt3 = Convert.ToInt16(0);
    int cnt2 = Convert.ToInt16(0);
    for (int i=0; i<num.Length; i++)
    {
        if (num[i]==5){
            cnt5++;
        }
        else if (num[i]==4){
            cnt4++;
        }
        else if (num[i]==3){
            cnt3++;
        }
        else if (num[i]==2){
            cnt2++;
        }
    }
    System.Console.WriteLine("5 : "+cnt5+"шт.");
    System.Console.WriteLine("4 : "+cnt4+"шт.");
    System.Console.WriteLine("3 : "+cnt3+"шт.");
    System.Console.WriteLine("2 : "+cnt2+"шт.");
}
metod(num);