int num = Convert.ToInt32(Console.ReadLine());
        int[] add = new int[num];
        for (int i = 0; i < num; i++)
        {
            add[i] = Convert.ToInt32(Console.ReadLine());
        }
        int cnt = 0;
        for (int i = 0; i < num; i++)
        {
            if (add[i] > 0 &&  add[i+1] > 0 )
            {
                System.Console.WriteLine("YES");
                break;
            }
            if (add[i] < 0 &&  add[i+1] < 0 )
            {
                System.Console.WriteLine("YES");
                break;
            }
            else{
                System.Console.WriteLine("NO");
                break;
            }
        }